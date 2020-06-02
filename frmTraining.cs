using Microsoft.ML;
using SpikeDetection.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnomalyDetectionSample
{
    public partial class frmTraining : Form
    {
        private static string BaseDatasetsRelativePath = @"D:\Stage2\StressApplicationFinal\Data";
        private static string TrainDataRelativePath = $"{BaseDatasetsRelativePath}/HeartTraining.csv";
        private static string TestDataRelativePath = $"{BaseDatasetsRelativePath}/HeartTest.csv";

        private static string TrainDataPath = GetAbsolutePath(TrainDataRelativePath);
        private static string TestDataPath = GetAbsolutePath(TestDataRelativePath);


        private static string BaseModelsRelativePath = @"D:\Stage2\StressApplicationFinal\MLModels";
        private static string ModelRelativePath = $"{BaseModelsRelativePath}/HeartClassification.zip";

        private static string ModelPath = GetAbsolutePath(ModelRelativePath);
        public static string Accuy = "";
        public static MLContext mlContext = new MLContext();
        public frmTraining()
        {
            InitializeComponent();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            BuildTrainEvaluateAndSaveModel(mlContext);
            txtAccuracy.Text = Accuy;
        }
        private static void BuildTrainEvaluateAndSaveModel(MLContext mlContext)
        {
            // STEP 1: Common data loading configuration
            var trainingDataView = mlContext.Data.LoadFromTextFile<HeartData>(TrainDataPath, hasHeader: true, separatorChar: ';');
            var testDataView = mlContext.Data.LoadFromTextFile<HeartData>(TestDataPath, hasHeader: true, separatorChar: ';');

            // STEP 2: Concatenate the features and set the training algorithm
            var pipeline = mlContext.Transforms.Concatenate("Features", "Age", "Sex", "Cp", "TrestBps", "Chol", "Fbs", "RestEcg", "Thalac", "Exang", "OldPeak", "Slope", "Ca", "Thal")
                .Append(mlContext.BinaryClassification.Trainers.FastTree(labelColumnName: "Label", featureColumnName: "Features"));


            ITransformer trainedModel = pipeline.Fit(trainingDataView);


            //"===== Evaluating Model's accuracy with Test data =====");
            var predictions = trainedModel.Transform(testDataView);

            var metrics = mlContext.BinaryClassification.Evaluate(data: predictions, labelColumnName: "Label", scoreColumnName: "Score");
            Accuy = metrics.Accuracy.ToString();


            //"=============== Saving the model to a file ===============");
            mlContext.Model.Save(trainedModel, trainingDataView.Schema, ModelPath);

        }
        public static string GetAbsolutePath(string relativePath)
        {
            FileInfo _dataRoot = new FileInfo(typeof(Program).Assembly.Location);
            string assemblyFolderPath = _dataRoot.Directory.FullName;

            string fullPath = Path.Combine(assemblyFolderPath, relativePath);

            return fullPath;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
