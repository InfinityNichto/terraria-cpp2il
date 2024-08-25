using System;
using System.IO;
using Cpp2ILInjected;

[global::Cpp2ILInjected.Token(Token = "0x200006D")]
public interface FileAPI
{
	[global::Cpp2ILInjected.Token(Token = "0x600025B")]
	string GetUserSavePath();

	[global::Cpp2ILInjected.Token(Token = "0x600025C")]
	void LegacySync();

	[global::Cpp2ILInjected.Token(Token = "0x600025D")]
	void Mount(bool forSync);

	[global::Cpp2ILInjected.Token(Token = "0x600025E")]
	void Unmount(bool forSync);

	[global::Cpp2ILInjected.Token(Token = "0x600025F")]
	void CreateDirectory(string directory);

	[global::Cpp2ILInjected.Token(Token = "0x6000260")]
	void WriteFile(string filename, byte[] fileData);

	[global::Cpp2ILInjected.Token(Token = "0x6000261")]
	void Delete(string filename);

	[global::Cpp2ILInjected.Token(Token = "0x6000262")]
	byte[] ReadFile(string filename);

	[global::Cpp2ILInjected.Token(Token = "0x6000263")]
	bool Exists(string filename);

	[global::Cpp2ILInjected.Token(Token = "0x6000264")]
	string[] GetFiles(string filename, string searchPattern);

	[global::Cpp2ILInjected.Token(Token = "0x6000265")]
	string[] GetFolders(string filename);

	[global::Cpp2ILInjected.Token(Token = "0x6000266")]
	void SetAttributes(string filename, FileAttributes fileAttributes);

	[global::Cpp2ILInjected.Token(Token = "0x6000267")]
	void Shutdown();
}
