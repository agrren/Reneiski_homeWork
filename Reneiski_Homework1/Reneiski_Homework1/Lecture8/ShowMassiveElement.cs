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

                string? inputedValue = Console.ReadLine();

                string? checkedValue = inputedValue.Equals(string.Empty) ? null : inputedValue;

                int inputtedNumber = Int32.Parse(checkedValue);

                if (inputtedNumber == 0)
                {
                    throw new ZeroIndexException();
                }

                int massiveElement = massive[inputtedNumber];

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
