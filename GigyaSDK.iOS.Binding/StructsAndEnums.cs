using ObjCRuntime;

namespace GigyaSDK.iOS
{
	[Native]
	public enum GSErrorCode : long
	{
		CanceledByUser = 200001,
		MissingRequiredParameter = 400002,
		InvalidAccessToken = 403001,
		InvalidTime = 403002,
		UnauthorizedUser = 403005,
		PermissionDenied = 403007,
		NoValidSession = 403012,
		PermissionNotRequested = 403022,
		ServerLoginFailure = 500002,
		ProviderError = 500023,
		NetworkFailure = 500026,
		LoadFailed = 500032,
		JSException = 405001
	}
}