using System.IO;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface FileAPI
{
	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GetUserSavePath();

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LegacySync();

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void Mount(bool forSync);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void Unmount(bool forSync);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CreateDirectory(string directory);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void WriteFile(string filename, byte[] fileData);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void Delete(string filename);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	byte[] ReadFile(string filename);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool Exists(string filename);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string[] GetFiles(string filename, string searchPattern);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string[] GetFolders(string filename);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void SetAttributes(string filename, FileAttributes fileAttributes);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Shutdown();
}
