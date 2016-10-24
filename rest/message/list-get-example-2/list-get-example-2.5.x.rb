# Get twilio-ruby from twilio.com/docs/ruby/install
require 'twilio-ruby'

# Get your Account Sid and Auth Token from twilio.com/user/account
account_sid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX'
auth_token = 'your_auth_token'

# Initialize Twilio Client
@client = Twilio::REST::Client.new(account_sid, auth_token)

# Get all messages that match the given values
@client.account.messages.list(
  to: 'to_number',
  from: 'from_number',
  date_sent: Time.new('2015-04-01T00:00:00Z')
).each do |message|
  # print the body for each message
  puts message.body
end
