using System.Collections.ObjectModel;

namespace Medicinery.Pages;

public partial class HomePage : ContentPage
{

    public ObservableCollection<Medicine> Medicines { get; set; }
    public HomePage()
    {
        InitializeComponent();

        BindingContext = new HomePageViewModel(Navigation);
        Medicines = new ObservableCollection<Medicine>
            {
                new Medicine { Name = "Paracetamol", Icon = "paracetamol_icon.png" },
                new Medicine { Name = "Amoxicillin", Icon = "amoxicillin_icon.png" },
                new Medicine { Name = "Aspirin", Icon = "aspirin_icon.png" },
                new Medicine { Name = "Ibuprofen", Icon = "ibuprofen_icon.png" },
                new Medicine { Name = "Metformin", Icon = "metformin_icon.png" },
                new Medicine { Name = "Lisinopril", Icon = "lisinopril_icon.png" },
                new Medicine { Name = "Antacids", Icon = "antacids_icon.png" },
                new Medicine { Name = "Loperamide", Icon = "loperamide_icon.png" }
            };

        BindingContext = this;

    }

   
}

