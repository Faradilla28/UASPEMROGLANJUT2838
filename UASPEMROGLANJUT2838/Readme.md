## UASPEMROGLANJUT2838
Faradilla

19.11.2838

## Description
Program ini bertujuan menambahkan sebuah barang kedalam keranjang secara digital

## Scope of  Functionalities
- User dapat menambahkan barang secara digital
- user dapat menambahkan fungsi voucher
- user dapat melihat voucher yang ditawarkan, dll

## How does it works
Diawali dari method `MainWindow` pada class MainWindow.xaml.cs cara mendeklarasikan sebagai berikut,,,
```csharp
 public MainWindow()
        {
            InitializeComponent();
            payment = new Payment(this);
            KeranjangBelanja keranjangBelanja = new KeranjangBelanja(payment, this);
            controller = new MainWindowController(keranjangBelanja, payment);

            listKeranjangBelanja.ItemsSource = controller.getItems();
            listPromo.ItemsSource = controller.getDiskon();

            initializeView();

        }
```

logika perhitungan untuk melakukan kalkulasi terdapat pada class Payment.cs
```csharp
 class Payment
    {
        OnPaymentChangedListener paymentListener;
        public Payment(OnPaymentChangedListener paymentListener)
        {

            this.paymentListener = paymentListener;
        }

        public void updateTotal(double subTotal, double promo)
        {

            double total = subTotal - promo;
            this.paymentListener.onPriceUpdated(subTotal, total, promo);

        }
    }
```