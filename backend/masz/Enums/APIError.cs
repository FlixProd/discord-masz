namespace masz.Enums
{
    public enum APIError
    {
        Unknown = 0,
        InvalidDiscordUser = 1,
        ProtectedModCaseSuspect = 2,
        ProtectedModCaseSuspectIsBot = 3,
        ProtectedModCaseSuspectIsSiteAdmin = 4,
        ProtectedModCaseSuspectIsTeam = 5,
        ResourceNotFound = 6,
        InvalidIdentity = 7,
        GuildUnregistered = 8,
        Unauthorized = 9,
        GuildUndefinedMutedRoles = 10,
        ModCaseIsMarkedToBeDeleted = 11,
        ModCaseIsNotMarkedToBeDeleted = 12,
        GuildAlreadyRegistered = 13,
        NotAllowedInDemoMode = 14,
        RoleNotFound = 15,
        TokenCannotManageThisResource = 16,
        TokenAlreadyRegistered = 17,
        CannotBeSameUser = 18,
        ResourceAlreadyExists = 19,
    }
}