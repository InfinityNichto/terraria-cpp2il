using System;
using Cpp2ILInjected;

namespace System.Net
{
	// Token: 0x020000D7 RID: 215
	[global::Cpp2ILInjected.Token(Token = "0x200013D")]
	public enum HttpStatusCode
	{
		// Token: 0x0400046D RID: 1133
		[global::Cpp2ILInjected.Token(Token = "0x40005F3")]
		Continue = 100,
		// Token: 0x0400046E RID: 1134
		[global::Cpp2ILInjected.Token(Token = "0x40005F4")]
		SwitchingProtocols,
		// Token: 0x0400046F RID: 1135
		[global::Cpp2ILInjected.Token(Token = "0x40005F5")]
		Processing,
		// Token: 0x04000470 RID: 1136
		[global::Cpp2ILInjected.Token(Token = "0x40005F6")]
		EarlyHints,
		// Token: 0x04000471 RID: 1137
		[global::Cpp2ILInjected.Token(Token = "0x40005F7")]
		OK = 200,
		// Token: 0x04000472 RID: 1138
		[global::Cpp2ILInjected.Token(Token = "0x40005F8")]
		Created,
		// Token: 0x04000473 RID: 1139
		[global::Cpp2ILInjected.Token(Token = "0x40005F9")]
		Accepted,
		// Token: 0x04000474 RID: 1140
		[global::Cpp2ILInjected.Token(Token = "0x40005FA")]
		NonAuthoritativeInformation,
		// Token: 0x04000475 RID: 1141
		[global::Cpp2ILInjected.Token(Token = "0x40005FB")]
		NoContent,
		// Token: 0x04000476 RID: 1142
		[global::Cpp2ILInjected.Token(Token = "0x40005FC")]
		ResetContent,
		// Token: 0x04000477 RID: 1143
		[global::Cpp2ILInjected.Token(Token = "0x40005FD")]
		PartialContent,
		// Token: 0x04000478 RID: 1144
		[global::Cpp2ILInjected.Token(Token = "0x40005FE")]
		MultiStatus,
		// Token: 0x04000479 RID: 1145
		[global::Cpp2ILInjected.Token(Token = "0x40005FF")]
		AlreadyReported,
		// Token: 0x0400047A RID: 1146
		[global::Cpp2ILInjected.Token(Token = "0x4000600")]
		IMUsed = 226,
		// Token: 0x0400047B RID: 1147
		[global::Cpp2ILInjected.Token(Token = "0x4000601")]
		MultipleChoices = 300,
		// Token: 0x0400047C RID: 1148
		[global::Cpp2ILInjected.Token(Token = "0x4000602")]
		Ambiguous = 300,
		// Token: 0x0400047D RID: 1149
		[global::Cpp2ILInjected.Token(Token = "0x4000603")]
		MovedPermanently,
		// Token: 0x0400047E RID: 1150
		[global::Cpp2ILInjected.Token(Token = "0x4000604")]
		Moved = 301,
		// Token: 0x0400047F RID: 1151
		[global::Cpp2ILInjected.Token(Token = "0x4000605")]
		Found,
		// Token: 0x04000480 RID: 1152
		[global::Cpp2ILInjected.Token(Token = "0x4000606")]
		Redirect = 302,
		// Token: 0x04000481 RID: 1153
		[global::Cpp2ILInjected.Token(Token = "0x4000607")]
		SeeOther,
		// Token: 0x04000482 RID: 1154
		[global::Cpp2ILInjected.Token(Token = "0x4000608")]
		RedirectMethod = 303,
		// Token: 0x04000483 RID: 1155
		[global::Cpp2ILInjected.Token(Token = "0x4000609")]
		NotModified,
		// Token: 0x04000484 RID: 1156
		[global::Cpp2ILInjected.Token(Token = "0x400060A")]
		UseProxy,
		// Token: 0x04000485 RID: 1157
		[global::Cpp2ILInjected.Token(Token = "0x400060B")]
		Unused,
		// Token: 0x04000486 RID: 1158
		[global::Cpp2ILInjected.Token(Token = "0x400060C")]
		TemporaryRedirect,
		// Token: 0x04000487 RID: 1159
		[global::Cpp2ILInjected.Token(Token = "0x400060D")]
		RedirectKeepVerb = 307,
		// Token: 0x04000488 RID: 1160
		[global::Cpp2ILInjected.Token(Token = "0x400060E")]
		PermanentRedirect,
		// Token: 0x04000489 RID: 1161
		[global::Cpp2ILInjected.Token(Token = "0x400060F")]
		BadRequest = 400,
		// Token: 0x0400048A RID: 1162
		[global::Cpp2ILInjected.Token(Token = "0x4000610")]
		Unauthorized,
		// Token: 0x0400048B RID: 1163
		[global::Cpp2ILInjected.Token(Token = "0x4000611")]
		PaymentRequired,
		// Token: 0x0400048C RID: 1164
		[global::Cpp2ILInjected.Token(Token = "0x4000612")]
		Forbidden,
		// Token: 0x0400048D RID: 1165
		[global::Cpp2ILInjected.Token(Token = "0x4000613")]
		NotFound,
		// Token: 0x0400048E RID: 1166
		[global::Cpp2ILInjected.Token(Token = "0x4000614")]
		MethodNotAllowed,
		// Token: 0x0400048F RID: 1167
		[global::Cpp2ILInjected.Token(Token = "0x4000615")]
		NotAcceptable,
		// Token: 0x04000490 RID: 1168
		[global::Cpp2ILInjected.Token(Token = "0x4000616")]
		ProxyAuthenticationRequired,
		// Token: 0x04000491 RID: 1169
		[global::Cpp2ILInjected.Token(Token = "0x4000617")]
		RequestTimeout,
		// Token: 0x04000492 RID: 1170
		[global::Cpp2ILInjected.Token(Token = "0x4000618")]
		Conflict,
		// Token: 0x04000493 RID: 1171
		[global::Cpp2ILInjected.Token(Token = "0x4000619")]
		Gone,
		// Token: 0x04000494 RID: 1172
		[global::Cpp2ILInjected.Token(Token = "0x400061A")]
		LengthRequired,
		// Token: 0x04000495 RID: 1173
		[global::Cpp2ILInjected.Token(Token = "0x400061B")]
		PreconditionFailed,
		// Token: 0x04000496 RID: 1174
		[global::Cpp2ILInjected.Token(Token = "0x400061C")]
		RequestEntityTooLarge,
		// Token: 0x04000497 RID: 1175
		[global::Cpp2ILInjected.Token(Token = "0x400061D")]
		RequestUriTooLong,
		// Token: 0x04000498 RID: 1176
		[global::Cpp2ILInjected.Token(Token = "0x400061E")]
		UnsupportedMediaType,
		// Token: 0x04000499 RID: 1177
		[global::Cpp2ILInjected.Token(Token = "0x400061F")]
		RequestedRangeNotSatisfiable,
		// Token: 0x0400049A RID: 1178
		[global::Cpp2ILInjected.Token(Token = "0x4000620")]
		ExpectationFailed,
		// Token: 0x0400049B RID: 1179
		[global::Cpp2ILInjected.Token(Token = "0x4000621")]
		MisdirectedRequest = 421,
		// Token: 0x0400049C RID: 1180
		[global::Cpp2ILInjected.Token(Token = "0x4000622")]
		UnprocessableEntity,
		// Token: 0x0400049D RID: 1181
		[global::Cpp2ILInjected.Token(Token = "0x4000623")]
		Locked,
		// Token: 0x0400049E RID: 1182
		[global::Cpp2ILInjected.Token(Token = "0x4000624")]
		FailedDependency,
		// Token: 0x0400049F RID: 1183
		[global::Cpp2ILInjected.Token(Token = "0x4000625")]
		UpgradeRequired = 426,
		// Token: 0x040004A0 RID: 1184
		[global::Cpp2ILInjected.Token(Token = "0x4000626")]
		PreconditionRequired = 428,
		// Token: 0x040004A1 RID: 1185
		[global::Cpp2ILInjected.Token(Token = "0x4000627")]
		TooManyRequests,
		// Token: 0x040004A2 RID: 1186
		[global::Cpp2ILInjected.Token(Token = "0x4000628")]
		RequestHeaderFieldsTooLarge = 431,
		// Token: 0x040004A3 RID: 1187
		[global::Cpp2ILInjected.Token(Token = "0x4000629")]
		UnavailableForLegalReasons = 451,
		// Token: 0x040004A4 RID: 1188
		[global::Cpp2ILInjected.Token(Token = "0x400062A")]
		InternalServerError = 500,
		// Token: 0x040004A5 RID: 1189
		[global::Cpp2ILInjected.Token(Token = "0x400062B")]
		NotImplemented,
		// Token: 0x040004A6 RID: 1190
		[global::Cpp2ILInjected.Token(Token = "0x400062C")]
		BadGateway,
		// Token: 0x040004A7 RID: 1191
		[global::Cpp2ILInjected.Token(Token = "0x400062D")]
		ServiceUnavailable,
		// Token: 0x040004A8 RID: 1192
		[global::Cpp2ILInjected.Token(Token = "0x400062E")]
		GatewayTimeout,
		// Token: 0x040004A9 RID: 1193
		[global::Cpp2ILInjected.Token(Token = "0x400062F")]
		HttpVersionNotSupported,
		// Token: 0x040004AA RID: 1194
		[global::Cpp2ILInjected.Token(Token = "0x4000630")]
		VariantAlsoNegotiates,
		// Token: 0x040004AB RID: 1195
		[global::Cpp2ILInjected.Token(Token = "0x4000631")]
		InsufficientStorage,
		// Token: 0x040004AC RID: 1196
		[global::Cpp2ILInjected.Token(Token = "0x4000632")]
		LoopDetected,
		// Token: 0x040004AD RID: 1197
		[global::Cpp2ILInjected.Token(Token = "0x4000633")]
		NotExtended = 510,
		// Token: 0x040004AE RID: 1198
		[global::Cpp2ILInjected.Token(Token = "0x4000634")]
		NetworkAuthenticationRequired
	}
}
