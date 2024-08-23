using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Cryptography;

// Token: 0x0200031C RID: 796
[CompilerGenerated]
[global::Cpp2ILInjected.Token(Token = "0x2000443")]
internal sealed class <PrivateImplementationDetails>
{
	// Token: 0x06001A9B RID: 6811 RVA: 0x0000791F File Offset: 0x00005B1F
	[global::Cpp2ILInjected.Token(Token = "0x6001DF4")]
	[global::Cpp2ILInjected.Address(RVA = "0x1E9245C", Offset = "0x1E9245C", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OidLookup), Member = "NativeOidToFriendlyName", MemberParameters = new object[]
	{
		typeof(string),
		typeof(OidGroup),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OidLookup), Member = "NativeFriendlyNameToOid", MemberParameters = new object[]
	{
		typeof(string),
		typeof(OidGroup),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LinuxNetworkInterface), Member = "get_OperationalStatus", ReturnType = typeof(OperationalStatus))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CategoryAttribute), Member = "GetLocalizedString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
	internal static uint ComputeStringHash(string s)
	{
		throw null;
	}

	// Token: 0x04000FA5 RID: 4005 RVA: 0x00002050 File Offset: 0x00000250
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001416")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed176 00C700F38385659BA060672F86D4A9A5376EADF9ED1CABB1C63290A0FDEFE36A;

	// Token: 0x04000FA6 RID: 4006 RVA: 0x00002150 File Offset: 0x00000350
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001417")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed172 04D9D643E5A26924DC98C9906714082D395DCB17CEE9674D5EBFEC15D098C2B5;

	// Token: 0x04000FA7 RID: 4007 RVA: 0x00002170 File Offset: 0x00000370
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001418")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed172 063691760A57230E8119DF650327304D68AE1C009E476E48BE8C73DCA199D374;

	// Token: 0x04000FA8 RID: 4008 RVA: 0x00002190 File Offset: 0x00000390
	// Note: this field is marked with 'hasfieldrva' and has an initial value of '504699990003189290'.
	[global::Cpp2ILInjected.Token(Token = "0x4001419")]
	internal static readonly long 1417FCAA8455DC8E3C88BF916DD5C75746A2597CC052F212A8E4394C890E012B;

	// Token: 0x04000FA9 RID: 4009 RVA: 0x00002190 File Offset: 0x00000390
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x400141A")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed168 27625E383C3A91E8B65BC745FF5D4048C82B883CCD293B07DED697BF82733811;

	// Token: 0x04000FAA RID: 4010 RVA: 0x00002199 File Offset: 0x00000399
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x400141B")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed172 2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70;

	// Token: 0x04000FAB RID: 4011 RVA: 0x000021B9 File Offset: 0x000003B9
	// Note: this field is marked with 'hasfieldrva' and has an initial value of '3377746965823497'.
	[global::Cpp2ILInjected.Token(Token = "0x400141C")]
	internal static readonly long 3505B8A2248AC03FE41ACADF8F29294572BBADEE1DD2E1A45D025766681C012C;

	// Token: 0x04000FAC RID: 4012 RVA: 0x000021B9 File Offset: 0x000003B9
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x400141D")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed170 356A582FCE68ACAE8FC944F7B4F0C0DA2BFF4A90D3767C75905F3EDE2E4E66CF;

	// Token: 0x04000FAD RID: 4013 RVA: 0x000021C5 File Offset: 0x000003C5
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x400141E")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed167 3981C8DFF7DC0FD5962B5FB863DD1A0D4119D320706BFF88FD6F636AC6B93AFF;

	// Token: 0x04000FAE RID: 4014 RVA: 0x000021CB File Offset: 0x000003CB
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x400141F")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed178 4186171278342045F6399928145039267A761B52DE295D22617755191250963B;

	// Token: 0x04000FAF RID: 4015 RVA: 0x000029B3 File Offset: 0x00000BB3
	// Note: this field is marked with 'hasfieldrva' and has an initial value of '144680345676153346'.
	[global::Cpp2ILInjected.Token(Token = "0x4001420")]
	internal static readonly long 6C8F647E1FCD63826D12272FF0930E9C16F1FFEF719948703A4C0F3B90052885;

	// Token: 0x04000FB0 RID: 4016 RVA: 0x000029B3 File Offset: 0x00000BB3
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001421")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed175 8109EF063456779751E8A4AEE94A0BE9AE32827B6EB153ABD7F40057FF2C9CE3;

	// Token: 0x04000FB1 RID: 4017 RVA: 0x00002A33 File Offset: 0x00000C33
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001422")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed173 9001C3EDE1D7E939C07996B84F82F7CBE59A7266C1FC2735E959E3C8609602E8;

	// Token: 0x04000FB2 RID: 4018 RVA: 0x00002A5F File Offset: 0x00000C5F
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001423")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed166 933B971C6388D594A23FA1559825DB5BEC8ADE2DB1240AA8FC9D0C684949E8C9;

	// Token: 0x04000FB3 RID: 4019 RVA: 0x00002A64 File Offset: 0x00000C64
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001424")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed167 9F58F1261D211553DE8FBC1AFA477C84EA3974B9BFF38223D771D0CDA787E15A;

	// Token: 0x04000FB4 RID: 4020 RVA: 0x00002A6A File Offset: 0x00000C6A
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001425")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed175 B849624EC20707184A433E21DAAC963906D4B261A19BD8F139F0E269E59E308C;

	// Token: 0x04000FB5 RID: 4021 RVA: 0x00002AEA File Offset: 0x00000CEA
	// Note: this field is marked with 'hasfieldrva' and has an initial value of '2814805602271264'.
	[global::Cpp2ILInjected.Token(Token = "0x4001426")]
	internal static readonly long BB6BB42AC5453BD8AA992CCB8929F1CB7D4E112E3FC56E57D711E106D1F72859;

	// Token: 0x04000FB6 RID: 4022 RVA: 0x00002AEA File Offset: 0x00000CEA
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001427")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed171 DFA7289CF8D8029ACEE90F30530C6926950E8DD20285772458F271AFD015BAD5;

	// Token: 0x04000FB7 RID: 4023 RVA: 0x00002AF8 File Offset: 0x00000CF8
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001428")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed177 E1284F363C1A2B6A4343050EF21AEF5522855D9D77B656F54D1933235476FADC;

	// Token: 0x04000FB8 RID: 4024 RVA: 0x00002CF2 File Offset: 0x00000EF2
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x4001429")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed174 E173D43DE98094098259467FF632B4FC61496AF96F3A354A006360D246E8166F;

	// Token: 0x04000FB9 RID: 4025 RVA: 0x00002D33 File Offset: 0x00000F33
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x400142A")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed169 E478CC6C0579E2198C99BFDE0ABAADC66644AF69312CB9D6E94E2D4E3559482A;

	// Token: 0x04000FBA RID: 4026 RVA: 0x00002D3D File Offset: 0x00000F3D
	// Note: this field is marked with 'hasfieldrva'.
	[global::Cpp2ILInjected.Token(Token = "0x400142B")]
	internal static readonly <PrivateImplementationDetails>.ValueTypeNPrivateSealed176 F2830F044682E33B39018B5912634835B641562914E192CA66C654F5E4492FA8;

	// Token: 0x02000484 RID: 1156
	[global::Cpp2ILInjected.Token(Token = "0x2000444")]
	[StructLayout(2, Pack = 1, Size = 5)]
	private struct ValueTypeNPrivateSealed166
	{
	}

	// Token: 0x02000485 RID: 1157
	[global::Cpp2ILInjected.Token(Token = "0x2000445")]
	[StructLayout(2, Pack = 1, Size = 6)]
	private struct ValueTypeNPrivateSealed167
	{
	}

	// Token: 0x02000486 RID: 1158
	[global::Cpp2ILInjected.Token(Token = "0x2000446")]
	[StructLayout(2, Pack = 1, Size = 9)]
	private struct ValueTypeNPrivateSealed168
	{
	}

	// Token: 0x02000487 RID: 1159
	[global::Cpp2ILInjected.Token(Token = "0x2000447")]
	[StructLayout(2, Pack = 1, Size = 10)]
	private struct ValueTypeNPrivateSealed169
	{
	}

	// Token: 0x02000488 RID: 1160
	[global::Cpp2ILInjected.Token(Token = "0x2000448")]
	[StructLayout(2, Pack = 1, Size = 12)]
	private struct ValueTypeNPrivateSealed170
	{
	}

	// Token: 0x02000489 RID: 1161
	[global::Cpp2ILInjected.Token(Token = "0x2000449")]
	[StructLayout(2, Pack = 1, Size = 14)]
	private struct ValueTypeNPrivateSealed171
	{
	}

	// Token: 0x0200048A RID: 1162
	[global::Cpp2ILInjected.Token(Token = "0x200044A")]
	[StructLayout(2, Pack = 1, Size = 32)]
	private struct ValueTypeNPrivateSealed172
	{
	}

	// Token: 0x0200048B RID: 1163
	[global::Cpp2ILInjected.Token(Token = "0x200044B")]
	[StructLayout(2, Pack = 1, Size = 44)]
	private struct ValueTypeNPrivateSealed173
	{
	}

	// Token: 0x0200048C RID: 1164
	[global::Cpp2ILInjected.Token(Token = "0x200044C")]
	[StructLayout(2, Pack = 1, Size = 65)]
	private struct ValueTypeNPrivateSealed174
	{
	}

	// Token: 0x0200048D RID: 1165
	[global::Cpp2ILInjected.Token(Token = "0x200044D")]
	[StructLayout(2, Pack = 1, Size = 128)]
	private struct ValueTypeNPrivateSealed175
	{
	}

	// Token: 0x0200048E RID: 1166
	[global::Cpp2ILInjected.Token(Token = "0x200044E")]
	[StructLayout(2, Pack = 1, Size = 256)]
	private struct ValueTypeNPrivateSealed176
	{
	}

	// Token: 0x0200048F RID: 1167
	[global::Cpp2ILInjected.Token(Token = "0x200044F")]
	[StructLayout(2, Pack = 1, Size = 506)]
	private struct ValueTypeNPrivateSealed177
	{
	}

	// Token: 0x02000490 RID: 1168
	[global::Cpp2ILInjected.Token(Token = "0x2000450")]
	[StructLayout(2, Pack = 1, Size = 2024)]
	private struct ValueTypeNPrivateSealed178
	{
	}
}
