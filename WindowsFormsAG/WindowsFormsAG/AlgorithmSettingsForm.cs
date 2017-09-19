using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsAG.Model;
using WindowsFormsAG.Controller;

namespace WindowsFormsAG
{
    public partial class AlgorithmSettingsForm : Form
    {
        private AlgorthmParameters _parameters;

        private Harmonogram _prelimiarz;

        public AlgorithmSettingsForm(Harmonogram prelimiarz)
        {
            InitializeComponent();
            _parameters = prelimiarz.ParametryAlgorytmu;
            _prelimiarz = prelimiarz;

            numericOfChromosomes.Value = _parameters.NumberOfChromosomes;
            numericReplace.Value = _parameters.ReplaceByGeneration;
            numericTrackBest.Value = _parameters.TrackBest;
            numericOfCrossoverPoints.Value = _parameters.NumberOfCrossoverPoints;
            numericMutationSize.Value = _parameters.MutationSize;
            numericCrossoverProbability.Value = _parameters.CrossoverProbability;
            numericMutationProbability.Value = _parameters.MutationProbability;
        }

        private void numericOfChromosomes_ValueChanged(object sender, EventArgs e)
        {
            _prelimiarz.ParametryAlgorytmu.NumberOfChromosomes = Convert.ToInt32(numericOfChromosomes.Value);
        }

        private void numericReplace_ValueChanged(object sender, EventArgs e)
        {
            _prelimiarz.ParametryAlgorytmu.ReplaceByGeneration = Convert.ToInt32(numericReplace.Value);
        }

        private void numericTrackBest_ValueChanged(object sender, EventArgs e)
        {
            _prelimiarz.ParametryAlgorytmu.TrackBest = Convert.ToInt32(numericTrackBest.Value);
        }

        private void numericOfCrossoverPoints_ValueChanged(object sender, EventArgs e)
        {
            _prelimiarz.ParametryAlgorytmu.NumberOfCrossoverPoints = Convert.ToInt32(numericOfCrossoverPoints.Value);
        }

        private void numericMutationSize_ValueChanged(object sender, EventArgs e)
        {
            _prelimiarz.ParametryAlgorytmu.MutationSize = Convert.ToInt32(numericMutationSize.Value);
        }

        private void numericCrossoverProbability_ValueChanged(object sender, EventArgs e)
        {
            _prelimiarz.ParametryAlgorytmu.CrossoverProbability = Convert.ToInt32(numericCrossoverProbability.Value);
        }

        private void numericMutationProbability_ValueChanged(object sender, EventArgs e)
        {
            _prelimiarz.ParametryAlgorytmu.MutationProbability = Convert.ToInt32(numericMutationProbability.Value);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
