using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000250 RID: 592
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002ED")]
	public sealed class RijndaelManaged : Rijndael
	{
		// Token: 0x06001708 RID: 5896 RVA: 0x000185AE File Offset: 0x000167AE
		[global::Cpp2ILInjected.Token(Token = "0x6001922")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B02710", Offset = "0x1B02710", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "LoadPersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "SavePersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Player_OldConsole", Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			"Terraria.IO.PlayerFileData"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Player_OldSwitch", Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			"Terraria.IO.PlayerFileData"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "InternalSavePlayerFile", MemberParameters = new object[] { "Terraria.IO.PlayerFileData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "LoadTutorialPlayer", ReturnType = "Terraria.IO.PlayerFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = "Terraria.IO.PlayerFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementManager", Member = "Save", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementManager", Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rijndael), Member = "Create", ReturnType = typeof(Rijndael))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymmetricAlgorithm), Member = "Create", ReturnType = typeof(SymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesManaged", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rijndael), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "get_AllowOnlyFipsAlgorithms", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public RijndaelManaged()
		{
			throw null;
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x000185B1 File Offset: 0x000167B1
		[global::Cpp2ILInjected.Token(Token = "0x6001923")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B029D0", Offset = "0x1B029D0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			throw null;
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x000185B4 File Offset: 0x000167B4
		[global::Cpp2ILInjected.Token(Token = "0x6001924")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B02B0C", Offset = "0x1B02B0C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManaged), Member = "NewEncryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(CipherMode),
			typeof(byte[]),
			typeof(int),
			typeof(RijndaelManagedTransformMode)
		}, ReturnType = typeof(ICryptoTransform))]
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			throw null;
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x000185B7 File Offset: 0x000167B7
		[global::Cpp2ILInjected.Token(Token = "0x6001925")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B02B20", Offset = "0x1B02B20", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void GenerateKey()
		{
			throw null;
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x000185BA File Offset: 0x000167BA
		[global::Cpp2ILInjected.Token(Token = "0x6001926")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B02B90", Offset = "0x1B02B90", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void GenerateIV()
		{
			throw null;
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x000185BD File Offset: 0x000167BD
		[global::Cpp2ILInjected.Token(Token = "0x6001927")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B029E4", Offset = "0x1B029E4", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManaged), Member = "CreateDecryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManagedTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(CipherMode),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(PaddingMode),
			typeof(RijndaelManagedTransformMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode)
		{
			throw null;
		}
	}
}
