using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;
using Mono.Security.X509;

// Token: 0x0200004A RID: 74
[CompilerGenerated]
[global::Cpp2ILInjected.Token(Token = "0x200006B")]
internal sealed class <PrivateImplementationDetails>
{
	// Token: 0x06000276 RID: 630 RVA: 0x00003675 File Offset: 0x00001875
	[global::Cpp2ILInjected.Token(Token = "0x60002FD")]
	[global::Cpp2ILInjected.Address(RVA = "0x1AA8F9C", Offset = "0x1AA8F9C", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetSymmetricAlgorithm", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(SymmetricAlgorithm))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(X520.AttributeTypeAndValue))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Builder), Member = "GetOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "get_Signature", ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "HashNameFromOid", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
	internal static uint ComputeStringHash(string s)
	{
		throw null;
	}

	// Token: 0x0400026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002A5")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed217 001D686DB504E20C792EAA07FE09224A45FF328E24A80072D04D16ABC5C2B5D2;

	// Token: 0x0400026B RID: 619 RVA: 0x00002090 File Offset: 0x00000290
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002A6")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed219 25E3E48132FBDBE9B7C0C6C54D7C10A5DE12A105AA3E5DE2A0DC808BF245B7A5;

	// Token: 0x0400026C RID: 620 RVA: 0x00002CCC File Offset: 0x00000ECC
	// Note: this field is marked with 'hasfieldrva' and has an initial value of '312160165825283157'.
	[global::Cpp2ILInjected.Token(Token = "0x40002A7")]
	internal static readonly long 290C4A052C215D096172EB81AEE671FB3286E5C1DB5E73F96021FC09825DDB88;

	// Token: 0x0400026D RID: 621 RVA: 0x00002CCC File Offset: 0x00000ECC
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002A8")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed210 32D0830B8EE1D49A66F395C8EA80E02BFC07C2A12A8EA8C8B484AF02108A1950;

	// Token: 0x0400026E RID: 622 RVA: 0x00002CCF File Offset: 0x00000ECF
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002A9")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed210 35BF50EEF3270FD8CA09E66FC5B0481C5A151B14F6A634854E32F63633D49DCB;

	// Token: 0x0400026F RID: 623 RVA: 0x00002CD2 File Offset: 0x00000ED2
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002AA")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed210 3C0C410618682C4DF0474E034114CC8E562F05A512B521AC367571017BDFA75D;

	// Token: 0x04000270 RID: 624 RVA: 0x00002CD5 File Offset: 0x00000ED5
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002AB")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed210 44F5B1A2C48314502ACCBF186D1A2F9F7F176825898F32F1A2047B956194F174;

	// Token: 0x04000271 RID: 625 RVA: 0x00002CD8 File Offset: 0x00000ED8
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002AC")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed216 4800FBFC4566EB02D1727A4B1C949CCBC7535C216A0766564C199308631B5DD6;

	// Token: 0x04000272 RID: 626 RVA: 0x00002D08 File Offset: 0x00000F08
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002AD")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed214 533B8C444F951E83EFF7305E3807B66CE0005DE0A2D0A44873C130895A3BE6AA;

	// Token: 0x04000273 RID: 627 RVA: 0x00002D1C File Offset: 0x00000F1C
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002AE")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed218 55D0BF716B334D123E0088CFB3F8E2FEA17AF5025BB527F95EEB09BA978EA329;

	// Token: 0x04000274 RID: 628 RVA: 0x00002E1C File Offset: 0x0000101C
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002AF")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed210 59BE5A634187B8A57216EFF5371A47732C05744B1C1A0A6382A6D5622C9FFDCE;

	// Token: 0x04000275 RID: 629 RVA: 0x00002E1F File Offset: 0x0000101F
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002B0")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed215 5DF6E0E2761359D30A8275058E299FCC0381534545F55CF43E41983F5D4C9456;

	// Token: 0x04000276 RID: 630 RVA: 0x00002E3F File Offset: 0x0000103F
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002B1")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed210 5F8C6B3C66B972606D85E7651F67ADBD02E8316876884674E8328FA710747E5B;

	// Token: 0x04000277 RID: 631 RVA: 0x00002E42 File Offset: 0x00001042
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002B2")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed212 60C6ED13AF98DBFEEDA8F8197FFFCC349BB04395CC81DF0D477CBC57BF5B398B;

	// Token: 0x04000278 RID: 632 RVA: 0x00002E4C File Offset: 0x0000104C
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002B3")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed212 64B3E7D737AFF47D4C3BBD81D2D06D697DDD8EB60F29E13E4425D19D8BBCA1F7;

	// Token: 0x04000279 RID: 633 RVA: 0x00002E56 File Offset: 0x00001056
	// Note: this field is marked with 'hasfieldrva' and has an initial value of '648815178079045162'.
	[global::Cpp2ILInjected.Token(Token = "0x40002B4")]
	internal static readonly long 6772A9B8BF207A3CFE6EE68769D6985B69522183F24A2A3D41BC3B4602953426;

	// Token: 0x0400027A RID: 634 RVA: 0x00002E56 File Offset: 0x00001056
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002B5")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed211 684312AFB7719E57993D2826FFBAF7EA965614F20F91D999FB19B01E21AA62E6;

	// Token: 0x0400027B RID: 635 RVA: 0x00002E5F File Offset: 0x0000105F
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002B6")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed217 6AA56C4BCD208911792AD24C7681FEFB93BED51903AFC54860C9BD37E41E5A31;

	// Token: 0x0400027C RID: 636 RVA: 0x00002E9F File Offset: 0x0000109F
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002B7")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed210 796E63069E193A008CB4E85573AA1FE53C5F4E58B42A7F61FD0EEE1D89B5120B;

	// Token: 0x0400027D RID: 637 RVA: 0x00002EA2 File Offset: 0x000010A2
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002B8")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed217 7C8975E1E60A5C8337F28EDF8C33C3B180360B7279644A9BC1AF3C51E6220BF5;

	// Token: 0x0400027E RID: 638 RVA: 0x00002EE2 File Offset: 0x000010E2
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002B9")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed210 850D7367E4FB0766E2CBC3ACF5AB42B4E98348E58E5A789845D4FCCDB63D2AEE;

	// Token: 0x0400027F RID: 639 RVA: 0x00002EE5 File Offset: 0x000010E5
	// Note: this field is marked with 'hasfieldrva' and has an initial value of '2450005477028070485'.
	[global::Cpp2ILInjected.Token(Token = "0x40002BA")]
	internal static readonly long 992F16C986809AB68C7466CC3EC6F12B2506A962EA539753E5D84A2FB7FF8A24;

	// Token: 0x04000280 RID: 640 RVA: 0x00002EE5 File Offset: 0x000010E5
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002BB")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed210 9A65C09A11757751BFED67A414E00B188DC4C7757FCB6CBD33A916DDE4A3D925;

	// Token: 0x04000281 RID: 641 RVA: 0x00002EE8 File Offset: 0x000010E8
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002BC")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed213 9ACEFCC0C950280B64AB9E045E38C34ABF71EC70A0DC61B9C621C6BFB4F78047;

	// Token: 0x04000282 RID: 642 RVA: 0x00002EFA File Offset: 0x000010FA
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002BD")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed210 B1E34F4A11EE411B83415EF0B252A0B2BBCFCAC2E592865E09C12E4252C93A75;

	// Token: 0x04000283 RID: 643 RVA: 0x00002EFD File Offset: 0x000010FD
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002BE")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed210 C92FAD7F348A682E7D5B7E74C76B5D019174EE7BC87545B25A1FDD49FBCC2D0B;

	// Token: 0x04000284 RID: 644 RVA: 0x00002F00 File Offset: 0x00001100
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002BF")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed210 E17B8359E685992B0DE6242AAA24FCB7404173CBB7FF8646FF7D658139F41B5F;

	// Token: 0x04000285 RID: 645 RVA: 0x00002F03 File Offset: 0x00001103
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002C0")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed217 F83B332BE4E6A5A4B1C56AAF6DB52657DA495E149870057D8590AB9D7A6167AD;

	// Token: 0x04000286 RID: 646 RVA: 0x00002F43 File Offset: 0x00001143
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x40002C1")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed210 FB6D7301FFDCB5FBA5807A19B4F0606947897C1105240B6BBA815352DBBE2064;

	// Token: 0x02000077 RID: 119
	[global::Cpp2ILInjected.Token(Token = "0x200006C")]
	[StructLayout(2, Pack = 1, Size = 3)]
	private struct ValueTypeNPrivateSealed210
	{
	}

	// Token: 0x02000078 RID: 120
	[global::Cpp2ILInjected.Token(Token = "0x200006D")]
	[StructLayout(2, Pack = 1, Size = 9)]
	private struct ValueTypeNPrivateSealed211
	{
	}

	// Token: 0x02000079 RID: 121
	[global::Cpp2ILInjected.Token(Token = "0x200006E")]
	[StructLayout(2, Pack = 1, Size = 10)]
	private struct ValueTypeNPrivateSealed212
	{
	}

	// Token: 0x0200007A RID: 122
	[global::Cpp2ILInjected.Token(Token = "0x200006F")]
	[StructLayout(2, Pack = 1, Size = 18)]
	private struct ValueTypeNPrivateSealed213
	{
	}

	// Token: 0x0200007B RID: 123
	[global::Cpp2ILInjected.Token(Token = "0x2000070")]
	[StructLayout(2, Pack = 1, Size = 20)]
	private struct ValueTypeNPrivateSealed214
	{
	}

	// Token: 0x0200007C RID: 124
	[global::Cpp2ILInjected.Token(Token = "0x2000071")]
	[StructLayout(2, Pack = 1, Size = 32)]
	private struct ValueTypeNPrivateSealed215
	{
	}

	// Token: 0x0200007D RID: 125
	[global::Cpp2ILInjected.Token(Token = "0x2000072")]
	[StructLayout(2, Pack = 1, Size = 48)]
	private struct ValueTypeNPrivateSealed216
	{
	}

	// Token: 0x0200007E RID: 126
	[global::Cpp2ILInjected.Token(Token = "0x2000073")]
	[StructLayout(2, Pack = 1, Size = 64)]
	private struct ValueTypeNPrivateSealed217
	{
	}

	// Token: 0x0200007F RID: 127
	[global::Cpp2ILInjected.Token(Token = "0x2000074")]
	[StructLayout(2, Pack = 1, Size = 256)]
	private struct ValueTypeNPrivateSealed218
	{
	}

	// Token: 0x02000080 RID: 128
	[global::Cpp2ILInjected.Token(Token = "0x2000075")]
	[StructLayout(2, Pack = 1, Size = 3132)]
	private struct ValueTypeNPrivateSealed219
	{
	}
}
