namespace Reneiski_Homework1.Lecture8
{
    public class ShowMassiveElement
    {        

        public void ShowMassive()
        {
            try
            {
                int[] massive = { 8, 7, 1, 4, 2 };

                Console.WriteLine("Input index of element in massive:");

                var inputedValue = Console.ReadLine();

                var checkedValue = inputedValue.Equals(string.Empty) ? null : inputedValue;

                var inputtedNumber = Int32.Parse(checkedValue);

                if (inputtedNumber == 0)
                {
                    throw new ZeroIndexException();
                }

                var massiveElement = massive[inputtedNumber];

                Console.WriteLine($"Massive element that has index {inputedValue} has value {massiveElement}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception is worrked off");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception is worrked off");
                Console.WriteLine(ex.Message);
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Exception is worrked off");
                Console.WriteLine(ex.Message);
            }
            catch (ZeroIndexException ex)
            {
                Console.WriteLine("Exception is worrked off");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
