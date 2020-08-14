result = gateway.payment_method.create(
  :customer_id => "the_customer_id",
  :payment_method_nonce => nonce_from_the_client,
  :options => {
    :verify_card => true,
    :verification_merchant_account_id => "the_merchant_account_id",
    :verification_amount => "2.00",
  }
)
