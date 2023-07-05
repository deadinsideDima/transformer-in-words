using System;
using System.Globalization;

namespace TransformerToWords
{
    /// <summary>
    /// Implements transformer class.
    /// </summary>
    public class Transformer
    {
        /// <summary>
        /// Transforms each element of source array into its 'word format'.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <returns>Array of 'word format' of elements of source array.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        /// <example>
        /// new[] { 2.345, -0.0d, 0.0d, 0.1d } => { "Two point three four five", "Minus zero", "Zero", "Zero point one" }.
        /// </example>
        public string[] Transform(double[]? source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Array is empty.");
            }

            string[] arr = new string[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                double number = source[i];
                string numberT = new string(number.ToString(CultureInfo.InvariantCulture));
                string convertNumber = string.Empty;
                if (number is double.NaN)
                {
                    arr[i] = "Not a Number";
                }
                else if (number == double.PositiveInfinity)
                {
                    arr[i] = "Positive Infinity";
                }
                else if (number == double.NegativeInfinity)
                {
                    arr[i] = "Negative Infinity";
                }
                else if (number == double.Epsilon)
                {
                    arr[i] = "Double Epsilon";
                }
                else
                {
                    if (numberT[0] == '-')
                    {
                        convertNumber = "Minus";
                    }
                    else if (numberT[0] == '0')
                    {
                        convertNumber = "Zero";
                    }
                    else if (numberT[0] == '1')
                    {
                        convertNumber = "One";
                    }
                    else if (numberT[0] == '2')
                    {
                        convertNumber = "Two";
                    }
                    else if (numberT[0] == '3')
                    {
                        convertNumber = "Three";
                    }
                    else if (numberT[0] == '4')
                    {
                        convertNumber = "Four";
                    }
                    else if (numberT[0] == '5')
                    {
                        convertNumber = "Five";
                    }
                    else if (numberT[0] == '6')
                    {
                        convertNumber = "Six";
                    }
                    else if (numberT[0] == '7')
                    {
                        convertNumber = "Seven";
                    }
                    else if (numberT[0] == '8')
                    {
                        convertNumber = "Eight";
                    }
                    else if (numberT[0] == '9')
                    {
                        convertNumber = "Nine";
                    }

                    for (int j = 1; j < numberT.Length; j++)
                    {
                        if (numberT[j] == '-')
                        {
                            convertNumber = string.Empty + convertNumber + " minus";
                        }
                        else if (numberT[j] == '+')
                        {
                            convertNumber = string.Empty + convertNumber + " plus";
                        }
                        else if (numberT[j] == '0')
                        {
                            convertNumber = string.Empty + convertNumber + " zero";
                        }
                        else if (numberT[j] == '1')
                        {
                            convertNumber = string.Empty + convertNumber + " one";
                        }
                        else if (numberT[j] == '2')
                        {
                            convertNumber = string.Empty + convertNumber + " two";
                        }
                        else if (numberT[j] == '3')
                        {
                            convertNumber = string.Empty + convertNumber + " three";
                        }
                        else if (numberT[j] == '4')
                        {
                            convertNumber = string.Empty + convertNumber + " four";
                        }
                        else if (numberT[j] == '5')
                        {
                            convertNumber = string.Empty + convertNumber + " five";
                        }
                        else if (numberT[j] == '6')
                        {
                            convertNumber = string.Empty + convertNumber + " six";
                        }
                        else if (numberT[j] == '7')
                        {
                            convertNumber = string.Empty + convertNumber + " seven";
                        }
                        else if (numberT[j] == '8')
                        {
                            convertNumber = string.Empty + convertNumber + " eight";
                        }
                        else if (numberT[j] == '9')
                        {
                            convertNumber = string.Empty + convertNumber + " nine";
                        }
                        else if (numberT[j] == '.')
                        {
                            convertNumber = string.Empty + convertNumber + " point";
                        }
                        else if (numberT[j] == 'E')
                        {
                            convertNumber = string.Empty + convertNumber + " E";
                        }
                    }

                    arr[i] = convertNumber;
                }
            }

            return arr;
        }
    }
}
