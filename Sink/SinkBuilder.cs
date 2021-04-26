using Kompas6API5;

namespace Sink
{
    public class SinkBuilder
    {
        /// <summary>
        /// Создание объекта
        /// </summary>
        /// <param name="parameter">Размеры объекта</param>
        public void BuildSink(SinkParameter parameter, KompasConnector kompasConnector)
        {
            kompasConnector.Doc3D = (ksDocument3D)kompasConnector.Kompas.Document3D();
            kompasConnector.Doc3D.Create(false, true);
            kompasConnector.KsPart = (ksPart)kompasConnector.Doc3D.GetPart(-1);

            //создание верхней части мойки
            ksEntity sketchSink = kompasConnector.KsPart.NewEntity(5);
            CreateRectangle(parameter.SinkLength, parameter.SinkWidth, sketchSink,
                kompasConnector.KsPart.GetDefaultEntity(1));
            CreateExtrusion(kompasConnector.KsPart, sketchSink, 0.5, false);

            //создание чаши мойки
            ksEntity sketchCupOffset = kompasConnector.KsPart.NewEntity(14);
            ksPlaneOffsetDefinition sketchCupDefinition = sketchCupOffset.GetDefinition();
            sketchCupDefinition.direction = true;
            sketchCupDefinition.offset = -100;
            ksEntity planeXOY = kompasConnector.KsPart.GetDefaultEntity(1);
            sketchCupDefinition.SetPlane(planeXOY);
            sketchCupOffset.Create();
            ksEntity sketchCup = kompasConnector.KsPart.NewEntity(5);
            CreateRectangle(parameter.CupSinkLength, parameter.CupSinkWidth,
                sketchCup, sketchCupOffset);
            CreateExtrusion(kompasConnector.KsPart, sketchCup, 100, true);

            ksEntity sketchDeepingOffset = kompasConnector.KsPart.NewEntity(14);
            ksPlaneOffsetDefinition sketchDeepingDefinition = sketchDeepingOffset.GetDefinition();
            sketchDeepingDefinition.direction = true;
            sketchDeepingDefinition.offset = -90;
            sketchDeepingDefinition.SetPlane(planeXOY);
            sketchDeepingOffset.Create();
            ksEntity sketchDeepening = kompasConnector.KsPart.NewEntity(5);
            CreateRectangle(parameter.CupSinkLength - 1, parameter.CupSinkWidth - 1,
                sketchDeepening, sketchDeepingOffset);
            CutExtrusion(kompasConnector.KsPart, sketchDeepening, parameter.SinkHeight);

            //создание отверстия для крана
            ksEntity sketchCraneHole = kompasConnector.KsPart.NewEntity(5);
            CreateCraneHole(0, (parameter.SinkLength / 2) - parameter.CraneHoleDiameter,
            parameter.CraneHoleDiameter / 2, sketchCraneHole,
            kompasConnector.KsPart.GetDefaultEntity(1));
            CutExtrusion(kompasConnector.KsPart, sketchCraneHole, 10);

            //создание отверстия для слива
            ksEntity sketchDrainHole = kompasConnector.KsPart.NewEntity(5);
            ksEntity sketchDrainHoleOffset = kompasConnector.KsPart.NewEntity(14);
            ksPlaneOffsetDefinition sketchDrainHoleDefinition = sketchDrainHoleOffset.GetDefinition();
            sketchDrainHoleDefinition.direction = true;
            sketchDrainHoleDefinition.offset = -100;
            sketchDrainHoleDefinition.SetPlane(planeXOY);
            sketchDrainHoleOffset.Create();
            CreateDrainHole(0, 0, parameter.DrainHoleDiameter / 2,
                sketchDrainHole, sketchDrainHoleOffset);
            CreateExtrusion(kompasConnector.KsPart, sketchDrainHole, 15, true);
            CutExtrusion(kompasConnector.KsPart, sketchDrainHole, 20);
           // CreateFillet(kompasConnector.KsPart, 5);
        }

        /// <summary>
        /// Операция выдавливание
        /// </summary>
        public void CreateExtrusion(ksPart part, ksEntity sketch, double depth, bool direction)
        {
            ksEntity extrusion = part.NewEntity(24);
            if (extrusion != null)
            {
                ksBaseExtrusionDefinition extrusionDefinition = extrusion.GetDefinition();
                extrusionDefinition.SetSideParam(direction, 0, depth);
                extrusionDefinition.SetSketch(sketch);
                extrusion.Create();
            }
        }

        /// <summary>
        /// Создание эскиза прямоугольника
        /// </summary>
        public void CreateRectangle(double length, double width, ksEntity sketch, ksEntity plane)
        {
            ksSketchDefinition sketchDefinition = sketch.GetDefinition();
            sketchDefinition.SetPlane(plane);
            sketch.Create();
            ksDocument2D sketchEdit = (ksDocument2D)sketchDefinition.BeginEdit();
            if (sketchEdit != null)
            {
                sketchEdit.ksLineSeg(width / 2, length / 2, width / 2, -length / 2, 1);
                sketchEdit.ksLineSeg(width / 2, -length / 2, -width / 2, -length / 2, 1);
                sketchEdit.ksLineSeg(-width / 2, -length / 2, -width / 2, length / 2, 1);
                sketchEdit.ksLineSeg(-width / 2, length / 2, width / 2, length / 2, 1);
                sketchDefinition.EndEdit();
            }
        }

        /// <summary>
        /// Создание эскиза отверстия для крана
        /// </summary>
        public void CreateCraneHole(double xCoordinate, double yCoordinate,
            double radius, ksEntity sketch, ksEntity plane)
        {
            ksSketchDefinition sketchDefinition = sketch.GetDefinition();
            sketchDefinition.SetPlane(plane);
            sketch.Create();
            ksDocument2D sketchEdit = (ksDocument2D)sketchDefinition.BeginEdit();
            if (sketchEdit != null)
            {
                sketchEdit.ksCircle(xCoordinate, yCoordinate, radius, 1);
                sketchDefinition.EndEdit();
            }
        }

        /// <summary>
        /// Создание эскиза отверстия для слива
        /// </summary>
        public void CreateDrainHole(double xCoordinate, double yCoordinate,
            double radius, ksEntity sketch, ksEntity plane)
        {
            ksSketchDefinition sketchDefinition = sketch.GetDefinition();
            sketchDefinition.SetPlane(plane);
            sketch.Create();
            ksDocument2D sketchEdit = (ksDocument2D)sketchDefinition.BeginEdit();

            if (sketchEdit != null)
            {
                sketchEdit.ksCircle(xCoordinate, yCoordinate, radius, 1);
                sketchDefinition.EndEdit();
            }
        }

        /// <summary>
        /// Операция вырезание выдавливанием
        /// </summary>
        public void CutExtrusion(ksPart part, ksEntity sketch, double depth)
        {
            ksEntity entityCutEntity = part.NewEntity(26);
            ksCutExtrusionDefinition cutEntityDef = (ksCutExtrusionDefinition)entityCutEntity.GetDefinition();
            cutEntityDef.SetThinParam(false);
            cutEntityDef.SetSideParam(false, 0, depth, 0);
            cutEntityDef.SetSketch(sketch);
            entityCutEntity.Create();
        }
        
        /// <summary>
        /// Операция скругление
        /// </summary>
        /// <param name="part">3D-модель компаса</param>
        /// <param name="radius">радиус скругления</param>
        /*private void CreateFillet(ksPart part, double radius)
        {
            var entityFillet = (ksEntity)part.NewEntity(34);
            var filletDefinition = (ksFilletDefinition)entityFillet.GetDefinition();
            filletDefinition.radius = radius;
            filletDefinition.tangent = true;
            var entityCollectionPart = (ksEntityCollection)part.EntityCollection(6);
            var entityCollectionFillet = (ksEntityCollection)filletDefinition.array();
            entityCollectionFillet.Clear();
            entityCollectionFillet.Add(entityCollectionPart.GetByIndex(5));
            entityCollectionFillet.Add(entityCollectionPart.GetByIndex(6));
            entityCollectionFillet.Add(entityCollectionPart.GetByIndex(7));
            entityCollectionFillet.Add(entityCollectionPart.GetByIndex(8));
            entityCollectionFillet.Add(entityCollectionPart.GetByIndex(9));
            entityCollectionFillet.Add(entityCollectionPart.GetByIndex(10));
            entityCollectionFillet.Add(entityCollectionPart.GetByIndex(11));
            entityCollectionFillet.Add(entityCollectionPart.GetByIndex(12));
            entityCollectionFillet.Add(entityCollectionPart.GetByIndex(13));
            entityCollectionFillet.Add(entityCollectionPart.GetByIndex(14));
            entityCollectionFillet.Add(entityCollectionPart.GetByIndex(15));
            entityFillet.Create();
        }*/
    }
}

