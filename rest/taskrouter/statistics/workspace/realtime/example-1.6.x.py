# Download the Python helper library from twilio.com/docs/python/install
from twilio.rest import Client

# Your Account Sid and Auth Token from twilio.com/user/account
account_sid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
auth_token = "your_auth_token"
workspace_sid = "WSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"

client = Client(account_sid, auth_token)

workspace = client.taskrouter.workspaces(workspace_sid)
statistics = workspace.real_time_statistics().fetch()

print(statistics.tasks_by_status.get("pending", None))
print(statistics.tasks_by_status.get("assigned", None))
