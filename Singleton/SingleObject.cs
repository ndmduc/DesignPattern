namespace Singleton
{
    public class SingleObject
    {
        /// <summary>
        /// The instance of SingleObject.
        /// </summary>
        private static SingleObject instance = new SingleObject();

        /// <summary>
        /// Prevents a default instance of the <see cref="SingleObject"/> class from being created.
        /// Make the constructor private so that this class cannot be instantiated.
        /// </summary>
        private SingleObject()
        {
        }

        /// <summary>
        /// The get instance.
        /// Get the only object available.
        /// </summary>
        /// <returns>
        /// The <see cref="SingleObject"/>.
        /// </returns>
        public static SingleObject GetInstance()
        {
            return instance;
        }

        public string ShowMessage()
        {
            return "Hello world";
        }
    }
}
