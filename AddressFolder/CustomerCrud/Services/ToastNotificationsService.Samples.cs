using Microsoft.Toolkit.Uwp.Notifications;

using Windows.UI.Notifications;

namespace CustomerCrud.Services
{
    internal partial class ToastNotificationsService
    {
        public void ShowToastNotificationSample(string message)
        {
            var customerService = new CustomerService();
            // Create the toast content
            var content = new ToastContent()
            {
                // TODO UWPTemplates: Check this documentation to know more about the Launch property
                // Documentation: https://developer.microsoft.com/en-us/windows/uwp-community-toolkit/api/microsoft_toolkit_uwp_notifications_toastcontent
                Launch = "ToastContentActivationParams",

                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
                        {
                            new AdaptiveText()
                            {
                                Text = "Address Book"
                            },

                            new AdaptiveText()
                            {
                                 Text = message
                            }
                        }
                    }
                },

                Actions = new ToastActionsCustom()
                {
                    Buttons =
                    {
                        // TODO UWPTemplates: Check this documentation to know more about Toast Buttons
                        // Documentation: https://developer.microsoft.com/en-us/windows/uwp-community-toolkit/api/microsoft_toolkit_uwp_notifications_toastbutton
                        new ToastButton("OK", "ToastButtonActivationArguments")
                        {
                            ActivationType = ToastActivationType.Foreground
                        },

                        new ToastButtonDismiss("Cancel")
                    }
                }
            };

            // Create the toast
            var toast = new ToastNotification(content.GetXml())
            {
                // TODO UWPTemplates: Gets or sets the unique identifier of this notification within the notification Group. Max length 16 characters.
                // Documentation: https://docs.microsoft.com/uwp/api/windows.ui.notifications.toastnotification
                Tag = "ToastTag"
            };

            // And show the toast
            ShowToastNotification(toast);
        }
    }
}
