using System;
using System.Drawing;
using System.Windows.Forms;
using Sink;

namespace SinkUI
{
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
            SinkBuilder _sinkBuilder = new SinkBuilder();
            _sinkBuilder.BuildSink(_sinkParameters, _kompasConnector);
        }

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

        private void SinkLengthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _sinkParameters.SinkLength = Convert.ToDouble(SinkLengthNumericUpDown.Value);
                SinkLengthNumericUpDown.BackColor = Color.White;
            }

            catch (Exception)
            {
                SinkLengthNumericUpDown.BackColor = Color.LightSalmon;
            }
        }

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