using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Syncfusion.Android.DataForm;

namespace Check_IsReadOnly_DataFormItem
{
    [Activity(Label = "Check_IsReadOnly_DataFormItem", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var dataForm = new SfDataForm(this);
            dataForm.RegisterEditor("Text", new DataFormTextEditorExt(dataForm));
            dataForm.DataObject = new ContactInfo();
            SetContentView(dataForm);
        }
    }
}
