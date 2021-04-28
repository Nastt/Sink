using System;
using System.Drawing;
using System.Windows.Forms;
using Sink;

namespace SinkUI
{
    //TODO: XML комментарии?
    public partial class MainForm : Form
    {
        /// <summary>
        /// Соединение с компасом
        /// </summary>
        private KompasConnector _kompasConnector = new KompasConnector();

        /// <summary>
        /// Параметры объекта
        /// </summary>
        private SinkParameter _sinkParameters = new SinkParameter();

        public MainForm()
        {
            InitializeComponent();
            AssignValue();
        }

        //TODO: XML комментарии?
        private void buildButton_Click(object sender, EventArgs e)
        {
            try
            {
                AssignValue();
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _kompasConnector.OpenKompas();
             //TODO: RSDN
            SinkBuilder _sinkBuilder = new SinkBuilder();
            _sinkBuilder.BuildSink(_sinkParameters, _kompasConnector);
        }

        //TODO: XML комментарии?
        private void AssignValue()
        {
            _sinkParameters.SinkLength = Convert.ToDouble(SinkLengthNumericUpDown.Value);
            _sinkParameters.SinkWidth = Convert.ToDouble(SinkWidthNumericUpDown.Value);
            _sinkParameters.SinkHeight = Convert.ToDouble(SinkHeightNumericUpDown.Value);
            _sinkParameters.CupSinkLength = Convert.ToDouble(CupSinkLengthNumericUpDown.Value);
            _sinkParameters.CupSinkWidth = Convert.ToDouble(CupSinkWidthNumericUpDown.Value);
            _sinkParameters.DrainHoleDiameter = Convert.ToDouble(DrainHoleDiameterNumericUpDown.Value);
            _sinkParameters.CraneHoleDiameter = Convert.ToDouble(CraneHoleDiameterNumericUpDown.Value);
        }

        //TODO: XML комментарии?
        private void SinkLengthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var tmpControl = (NumericUpDown) sender;
            try
            {
                // В словарь
                _sinkParameters.SinkLength = Convert.ToDouble(tmpControl.Value);
                tmpControl.BackColor = Color.White;
            }

            catch (Exception)
            {
                tmpControl.BackColor = Color.LightSalmon;
            }
        }

        //TODO: XML комментарии?
        private void SinkWidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _sinkParameters.SinkWidth = Convert.ToDouble(SinkWidthNumericUpDown.Value);
                SinkWidthNumericUpDown.BackColor = Color.White;
            }

            catch (Exception)
            {
                SinkWidthNumericUpDown.BackColor = Color.LightSalmon;
            }
        }

        //TODO: XML комментарии?
        private void CupSinkWidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _sinkParameters.CupSinkWidth = Convert.ToDouble(CupSinkWidthNumericUpDown.Value);
                CupSinkWidthNumericUpDown.BackColor = Color.White;
            }

            catch (Exception)
            {
                CupSinkWidthNumericUpDown.BackColor = Color.LightSalmon;
            }
        }

        //TODO: XML комментарии?
        private void CupSinkLengthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _sinkParameters.CupSinkLength = Convert.ToDouble(CupSinkLengthNumericUpDown.Value);
                CupSinkLengthNumericUpDown.BackColor = Color.White;
            }

            catch (Exception)
            {
                CupSinkLengthNumericUpDown.BackColor = Color.LightSalmon;
            }
        }

        //TODO: XML комментарии?
        private void SinkHeightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _sinkParameters.SinkHeight = Convert.ToDouble(SinkHeightNumericUpDown.Value);
                SinkHeightNumericUpDown.BackColor = Color.White;
            }

            catch (Exception)
            {
                SinkHeightNumericUpDown.BackColor = Color.LightSalmon;
            }
        }

        //TODO: XML комментарии?
        private void DrainHoleDiameterNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _sinkParameters.DrainHoleDiameter = Convert.ToDouble(DrainHoleDiameterNumericUpDown.Value);
                DrainHoleDiameterNumericUpDown.BackColor = Color.White;
            }

            catch (Exception)
            {
                DrainHoleDiameterNumericUpDown.BackColor = Color.LightSalmon;
            }
        }

        //TODO: XML комментарии?
        private void CraneHoleDiameterNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _sinkParameters.CraneHoleDiameter = Convert.ToDouble(CraneHoleDiameterNumericUpDown.Value);
                CraneHoleDiameterNumericUpDown.BackColor = Color.White;
            }

            catch (Exception)
            {
                CraneHoleDiameterNumericUpDown.BackColor = Color.LightSalmon;
            }
        }
    }
}