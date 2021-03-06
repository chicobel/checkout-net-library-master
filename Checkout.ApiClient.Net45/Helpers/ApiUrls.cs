﻿
using Checkout;
public class ApiUrls
{
    private static string _cardTokensApiUri;
    private static string _paymentTokensApiUri;
    private static string _cardChargesApiUri;
    private static string _cardTokenChargesApiUri;
    private static string _defaultCardChargesApiUri;
    private static string _chargeRefundsApiUri;
    private static string _chargeVoidApiUri;
    private static string _captureChargesApiUri;
    private static string _updateChargesApiUri;

    private static string _chargesApiUri;
    private static string _chargeApiUri;
    private static string _chargeHistoryApiUri;

    private static string _customersApiUri;
    private static string _customerApiUri;

    private static string _cardsApiUri;
    private static string _cardApiUri;

    public static void ResetApiUrls()
    {
        _cardTokensApiUri = null;
        _paymentTokensApiUri = null;
        _cardChargesApiUri = null;
        _cardTokenChargesApiUri = null;
        _defaultCardChargesApiUri = null;
        _chargeRefundsApiUri = null;
        _chargeVoidApiUri = null;
        _captureChargesApiUri = null;
        _updateChargesApiUri = null;
        _chargesApiUri = null;
        _chargeApiUri = null;
        _chargeHistoryApiUri = null;
        _customersApiUri = null;
        _customerApiUri = null;
        _cardsApiUri = null;
        _cardApiUri = null;
    }

    public static string Charges
    {
        get
        {
            return _chargesApiUri ?? (_chargesApiUri = string.Concat(AppSettings.BaseApiUri, "/charges"));
        }
    }

    public static string Charge
    {
        get
        {
            return _chargeApiUri ?? (_chargeApiUri = string.Concat(AppSettings.BaseApiUri, "/charges/{0}"));
        }
    }

    public static string ChargeHistory
    {
        get
        {
            return _chargeHistoryApiUri ?? (_chargeHistoryApiUri = string.Concat(AppSettings.BaseApiUri, "/charges/{0}/history"));
        }
    }

    public static string CaptureCharge
    {
        get
        {
            return _captureChargesApiUri ?? (_captureChargesApiUri = string.Concat(AppSettings.BaseApiUri, "/charges/{0}/capture"));
        }
    }

    public static string RefundCharge
    {
        get
        {
            return _chargeRefundsApiUri ?? (_chargeRefundsApiUri = string.Concat(AppSettings.BaseApiUri, "/charges/{0}/refund"));
        }
    }

    public static string VoidCharge
    {
        get
        {
            return _chargeVoidApiUri ?? (_chargeVoidApiUri = string.Concat(AppSettings.BaseApiUri, "/charges/{0}/void"));
        }
    }

    public static string DefaultCardCharge
    {
        get
        {
            return _defaultCardChargesApiUri ?? (_defaultCardChargesApiUri = string.Concat(AppSettings.BaseApiUri, "/charges/customer"));
        }
    }

    public static string CardTokenCharge
    {
        get
        {
            return _cardTokenChargesApiUri ?? (_cardTokenChargesApiUri = string.Concat(AppSettings.BaseApiUri, "/charges/token"));
        }
    }

    public static string CardCharge
    {
        get
        {
            return _cardChargesApiUri ?? (_cardChargesApiUri = string.Concat(AppSettings.BaseApiUri, "/charges/card"));
        }
    }

    public static string CardToken
    {
        get
        {
            return _cardTokensApiUri ?? (_cardTokensApiUri = string.Concat(AppSettings.BaseApiUri, "/tokens/card"));
        }
    }

    public static string PaymentToken
    {
        get
        {
            return _paymentTokensApiUri ?? (_paymentTokensApiUri = string.Concat(AppSettings.BaseApiUri, "/tokens/payment"));
        }
    }

    public static string Customers
    {
        get
        {
            return _customersApiUri ?? (_customersApiUri = string.Concat(AppSettings.BaseApiUri, "/customers"));
        }
    }
    public static string Customer
    {
        get
        {
            return _customerApiUri ?? (_customerApiUri = string.Concat(AppSettings.BaseApiUri, "/customers/{0}"));
        }
    }

    public static string Cards
    {
        get
        {
            return _cardsApiUri ?? (_cardsApiUri = string.Concat(AppSettings.BaseApiUri, "/customers/{0}/cards"));
        }
    }
    public static string Card
    {
        get
        {
            return _cardApiUri ?? (_cardApiUri = string.Concat(AppSettings.BaseApiUri, "/customers/{0}/cards/{1}"));
        }
    }




    public static string ShoppingList
    {
        get
        {

            return _ShoppingApiUri ?? (_ShoppingApiUri = string.Concat(AppSettings.BaseApiUri, "/shoppinglist/{0}"));
        }
    }

    public static string _ShoppingApiUri;

    public static string ShoppingToken
    {
        get
        {
            return _ShoppingTokenUri ?? (_ShoppingTokenUri = string.Concat(AppSettings.BaseApiUri, "/SToken"));
        }
    }

    public static string _ShoppingTokenUri;
}
