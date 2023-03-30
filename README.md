# SimpleNeuron.AI
Just a simple AI Neuron example

# Neuron
It include Neuron class implementation with methods of Process Data and Train method that allow to train Neuron based on input and expected result info.

# Examples
It include 2 example how to train and use Neuron:
- First one is convertation from the Miles to Kilometers and vice versa.
- Secound one is converation from USD to UAH and vice versa (based on today's goodle course).

You can see them as public methods in ProgramHelper.cs

# Note
Key values we should look on is: 
- Input value and expected result. The result of training depends on how correct and carefull this info
- Smoothing this is stem that have influense to training process. Smaller value give us more careful result but longer time to train and vice versa

# Warning
Comment Console.WriteLine command to have faster performance of training process, because output operation to console take a long time
