// Yandex Pay InApps Plugin.

namespace YPay
{
    public record YPayConfig(string MerchantId, string MerchantName, string MerchantUrl, string PaymentSessionKey, bool IsSandbox);
}
