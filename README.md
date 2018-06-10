<div dir="rtl">

# ZarinPalASPNETCore
درگاه پرداخت زرین‌پال

برای استفاده از زرین پال ابتدا یک نمونه از زرین پال بسازید: (تابع شما باید از نوع async باشد)

<div dir="ltr">
  
```c#
var payment = await new Zarinpal.Payment("YourMerchantId", Amount);
```
</div>

مقادبر ورودی:

YourMerchantId: کد مرچنت شما

Amount: مبلغ پرداختی

پس از ساختن نمونه میتوانید از توابع مورد نیاز خود استفاده کنید. توابع این بخش مربوط به پرداخت می باشد.

<div dir="ltr">
  
```c#
var result = payment.PaymentRequest(description,callbackUrl,email,mobile)
```
</div>

PaymentRequest: در خواست پرداخت که مقادیر ورودی به شرح زیر می باشد.

description: توضیحات مربوط به پرداخت

callbackUrl: آدرس بازگشتی

email: ایمیل (اختیاری)

mobile: شماره موبایل (اختیاری)

خروجی تابع به شرح زیر می باشد:

Status, Authority, Link

اعتبار سنجی پرداخت
------
نام تابع Verification

<div dir="ltr">
  
```c#
var result = payment.Verification(authority)
```
</div>
مقدار ورودی:

authority: authority بعد از ارسال درخواست پرداخت به شما بازگشت داده میشود که مقدار آن را در این تابع قرار می دهید.

خروجی :
Status, RefId

تابع PaymentRequestWithExtra:
------
<div dir="ltr">
  
```c#
var result = payment.PaymentRequestWithExtra(description, additionalData, additionalData, callbackUrl, email, mobile)
```
</div>
ورودی ها :

description: توضیحات

additionalData:داده های اضافی مطابق با توضیحات در مستندات زرین پال

callbackUrl

email: اختیاری

mobile: اختیاری

خروجی این تابع همانند تابع PaymentRequest می باشد.


اعتبار سنجی تابع PaymentRequestWithExtra:


نام تابع VerificationWithExtra:


var result = payment.VerificationWithExtra(authority)


خروجی :


Status, RefId, ExtraDetail





تمدید شناسه authority:


var refresh = await new Zarinpal.Refresh("YourMerchantId");


refresh.Authority(authority, expireIn);


expireIn: زمان تمدید به ثانیه





بازیابی تراکنش های ناموفق:


var get = await new Zarinpal.Get("YourMerchantId");


var result =  get.UnverifiedTransactions()


خروجی:


Status


Authorities


</div>





