namespace SimpleNeuron.AI
{
    public static class ProgramHelper
    {
        /// <summary>
        /// Use neuron to train and process operation to convert kilometers to miles and revers
        /// </summary>
        public static void ExecuteDistanceNeuronExample()
        {
            decimal km = 100;
            decimal miles = 62.1371m;

            //try neuron before train
            var neuronForKilometers = new Neuron();
            Console.WriteLine($"{neuronForKilometers.ProcessInputData(km)} miles in {km} kilometers");

            //train Neuron
            ProcessTrainCycle(neuronForKilometers, km, miles);


            //use neuron after train it
            Console.WriteLine($"{neuronForKilometers.ProcessInputData(km)} miles in {km} kilometers");
            Console.WriteLine($"{neuronForKilometers.ProcessInputData(1000)} miles in {1000} kilometers");
            Console.WriteLine($"{neuronForKilometers.ProcessInputData(1234)} miles in {1234} kilometers");
            Console.WriteLine($"{neuronForKilometers.ProcessInputData(500)} miles in {500} kilometers");
            Console.WriteLine($"{neuronForKilometers.RestoreInputData(10)} kilometers in {10} miles");
        }

        /// <summary>
        /// Use neuron to train and process operation to convert currencies (USD to UAH) and revere.
        /// It train, based on today's google course (there is not effect on weight if course was changes, it is only for demo, how neuron is working) 
        /// </summary>
        public static void ExecuteCurrencyNeuronExample()
        {
            decimal usd = 100;
            decimal uah = 3692.280m; //based on today google's course

            //try neuron before train
            var neuronForCurrencyUsdToUah = new Neuron();
            Console.WriteLine($"{neuronForCurrencyUsdToUah.ProcessInputData(usd)} uah in {usd} usd");

            //train Neuron
            ProcessTrainCycle(neuronForCurrencyUsdToUah, usd, uah);


            //use neuron after train it
            Console.WriteLine($"{neuronForCurrencyUsdToUah.ProcessInputData(usd)} uah in {usd} usd");
            Console.WriteLine($"{neuronForCurrencyUsdToUah.ProcessInputData(1000)} uah in {1000} usd");
            Console.WriteLine($"{neuronForCurrencyUsdToUah.ProcessInputData(1234)} uah in {1234} usd");
            Console.WriteLine($"{neuronForCurrencyUsdToUah.ProcessInputData(500)} uah in {500} usd");
            Console.WriteLine($"{neuronForCurrencyUsdToUah.RestoreInputData(10)} usd in {10} uah");
        }


        /// <summary>
        /// Just method that execute Train Cycle based on data we have. Train means calculate best weight
        /// </summary>
        /// <param name="neuron">Neuron we must train</param>
        /// <param name="input">Known input data</param>
        /// <param name="expectedResult">Known expected result for input data</param>
        static void ProcessTrainCycle(Neuron neuron, decimal input, decimal expectedResult)
        {
            int i = 0;
            do
            {
                i++;
                neuron.Train(input, expectedResult);

                //Console Output take a long time. Feel free to comment it if you want faster Neuron train process
                if (i % 100000 == 0)
                {
                    Console.WriteLine($"Iteration: {i}\tError:\t{neuron.LastError}");
                }
            } while (neuron.LastError > neuron.Smoothing || neuron.LastError < -neuron.Smoothing);
        }
    }
}
