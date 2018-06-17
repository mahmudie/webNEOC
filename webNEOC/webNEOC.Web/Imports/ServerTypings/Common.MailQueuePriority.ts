namespace webNEOC.Common {
    export enum MailQueuePriority {
        High = 1,
        Medium = 2,
        Low = 3
    }
    Serenity.Decorators.registerEnum(MailQueuePriority, 'webNEOC.Common.MailQueuePriority');
}

