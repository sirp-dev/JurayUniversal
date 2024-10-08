﻿namespace PostmarkEmailService.Model.Webhooks
{
    /// <summary>
    /// All triggers available for a WebhookConfiguration
    /// </summary>
    public class WebhookConfigurationTriggers
    {
        /// <summary>
        /// Settings for Open webhooks
        /// </summary>
        public WebhookConfigurationOpenTrigger Open { get; set; }

        /// <summary>
        /// Settings for Click webhooks
        /// </summary>
        public WebhookConfigurationClickTrigger Click { get; set; }

        /// <summary>
        /// Settings for Delivery webhooks
        /// </summary>
        public WebhookConfigurationDeliveryTrigger Delivery { get; set; }

        /// <summary>
        /// Settings for Bounce webhooks
        /// </summary>
        public WebhookConfigurationBounceTrigger Bounce { get; set; }

        /// <summary>
        /// Settings for SpamComplaint webhooks
        /// </summary>
        public WebhookConfigurationSpamComplaintTrigger SpamComplaint { get; set; }
    }
}