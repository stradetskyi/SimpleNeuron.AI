namespace SimpleNeuron.AI
{
    internal class Neuron
    {
        /// <summary>
        /// Main issue is to found the best _weight. How long train process will executed, well depends on how close is _weight to the best result.
        /// You can optimize your algorithm by changing weight closer to the best one, if you know it. But just some default like 0.5 is OK
        /// </summary>
        private decimal _weight = 0.5m;
        public decimal LastError { get; private set;  }
        /// <summary>
        /// Smaller Smoothing step give us more careful result but longer time to train and vice versa.
        /// </summary>
        public decimal Smoothing { get; private set; } = 0.00001m; //0.01m;

        public decimal ProcessInputData(decimal input)
        {
            return input * _weight;
        }

        public decimal RestoreInputData(decimal output)
        {
            return output / _weight;
        }

        /// <summary>
        /// Method we use to train Neuron. Train means calculate the best weight based on input and expected result.
        /// The result of training is depends on how careful input and expected result is, and Smoothing step.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="expectedResult"></param>
        public void Train(decimal input, decimal expectedResult)
        {
            var actualResult = input * _weight;

            LastError = expectedResult - actualResult;
            var correction = LastError / actualResult * Smoothing;
            _weight += correction;
        }
    }
}
