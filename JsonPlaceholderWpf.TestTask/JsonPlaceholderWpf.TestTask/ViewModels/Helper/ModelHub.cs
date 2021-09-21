namespace JsonPlaceholderWpf.TestTask.ViewModels.Helper
{
    public class ModelHub
    {

        public ModelHub()
        {
            JsonPlaceholderVM = new JsonPlaceholderViewModel();

        }


        public JsonPlaceholderViewModel JsonPlaceholderVM
        {
            get;
            set;
        }
    }
}
