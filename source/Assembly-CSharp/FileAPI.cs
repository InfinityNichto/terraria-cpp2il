using System;
using System.IO;
using Cpp2ILInjected;

// Token: 0x02000047 RID: 71
[global::Cpp2ILInjected.Token(Token = "0x200006D")]
public interface FileAPI
{
	// Token: 0x060001C8 RID: 456
	[global::Cpp2ILInjected.Token(Token = "0x600025B")]
	string GetUserSavePath();

	// Token: 0x060001C9 RID: 457
	[global::Cpp2ILInjected.Token(Token = "0x600025C")]
	void LegacySync();

	// Token: 0x060001CA RID: 458
	[global::Cpp2ILInjected.Token(Token = "0x600025D")]
	void Mount(bool forSync);

	// Token: 0x060001CB RID: 459
	[global::Cpp2ILInjected.Token(Token = "0x600025E")]
	void Unmount(bool forSync);

	// Token: 0x060001CC RID: 460
	[global::Cpp2ILInjected.Token(Token = "0x600025F")]
	void CreateDirectory(string directory);

	// Token: 0x060001CD RID: 461
	[global::Cpp2ILInjected.Token(Token = "0x6000260")]
	void WriteFile(string filename, byte[] fileData);

	// Token: 0x060001CE RID: 462
	[global::Cpp2ILInjected.Token(Token = "0x6000261")]
	void Delete(string filename);

	// Token: 0x060001CF RID: 463
	[global::Cpp2ILInjected.Token(Token = "0x6000262")]
	byte[] ReadFile(string filename);

	// Token: 0x060001D0 RID: 464
	[global::Cpp2ILInjected.Token(Token = "0x6000263")]
	bool Exists(string filename);

	// Token: 0x060001D1 RID: 465
	[global::Cpp2ILInjected.Token(Token = "0x6000264")]
	string[] GetFiles(string filename, string searchPattern);

	// Token: 0x060001D2 RID: 466
	[global::Cpp2ILInjected.Token(Token = "0x6000265")]
	string[] GetFolders(string filename);

	// Token: 0x060001D3 RID: 467
	[global::Cpp2ILInjected.Token(Token = "0x6000266")]
	void SetAttributes(string filename, FileAttributes fileAttributes);

	// Token: 0x060001D4 RID: 468
	[global::Cpp2ILInjected.Token(Token = "0x6000267")]
	void Shutdown();
}
