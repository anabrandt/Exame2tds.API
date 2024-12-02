using Microsoft.ML;
using Microsoft.ML.Data;
using Exame2tds.API.MachineLearning.Models;

namespace Exame2tds.API.MachineLearning.Services
{
    public class MachineLearningService
    {
        private readonly MLContext _mlContext;
        private ITransformer _model;

        public MachineLearningService()
        {
            _mlContext = new MLContext();
        }

        public void TrainModel()
        {
            // Dados fictícios para treinamento
            var data = new List<InputData>
            {
                new InputData { Feature1 = 1.0f, Feature2 = 2.0f },
                new InputData { Feature1 = 2.0f, Feature2 = 3.0f },
                new InputData { Feature1 = 3.0f, Feature2 = 5.0f },
            };

            var dataView = _mlContext.Data.LoadFromEnumerable(data);

            // Pipeline de treinamento
            var pipeline = _mlContext.Transforms
                .Concatenate("Features", nameof(InputData.Feature1), nameof(InputData.Feature2))
                .Append(_mlContext.Regression.Trainers.Sdca());

            // Treinar o modelo
            _model = pipeline.Fit(dataView);
        }

        public float Predict(InputData inputData)
        {
            var predictionEngine = _mlContext.Model.CreatePredictionEngine<InputData, PredictionOutput>(_model);
            var prediction = predictionEngine.Predict(inputData);

            return prediction.PredictedValue;
        }
    }
}
