namespace SwapOverrideReturnLib
{
    public class Swapper
    {
        /// <summary>
        /// Меняет значения полей между собой так, чтобы X = Y, Y = Z, Z = X.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        public static void ValueSwap<T>(ref T X, ref T Y, ref T Z)
        {
            (X, Y, Z) = (Y, Z, X);
        }
    }
}
