namespace Medicinery.Models
{
    public partial class AddToCart : ObservableObject
    {
        public Guid Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        [ObservableProperty, NotifyPropertyChangedFor(nameof(Amount))]
        public int _quantity;
        public decimal Amount => Price * Quantity;

    }
}
