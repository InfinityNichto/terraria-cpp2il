using System;
using Cpp2ILInjected;

namespace Mono.Security.Interface
{
	[CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000047")]
	public enum CipherSuiteCode : ushort
	{
		[global::Cpp2ILInjected.Token(Token = "0x400011B")]
		TLS_NULL_WITH_NULL_NULL,
		[global::Cpp2ILInjected.Token(Token = "0x400011C")]
		TLS_RSA_WITH_NULL_MD5,
		[global::Cpp2ILInjected.Token(Token = "0x400011D")]
		TLS_RSA_WITH_NULL_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400011E")]
		TLS_RSA_EXPORT_WITH_RC4_40_MD5,
		[global::Cpp2ILInjected.Token(Token = "0x400011F")]
		TLS_RSA_WITH_RC4_128_MD5,
		[global::Cpp2ILInjected.Token(Token = "0x4000120")]
		TLS_RSA_WITH_RC4_128_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000121")]
		TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5,
		[global::Cpp2ILInjected.Token(Token = "0x4000122")]
		TLS_RSA_WITH_IDEA_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000123")]
		TLS_RSA_EXPORT_WITH_DES40_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000124")]
		TLS_RSA_WITH_DES_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000125")]
		TLS_RSA_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000126")]
		TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000127")]
		TLS_DH_DSS_WITH_DES_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000128")]
		TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000129")]
		TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400012A")]
		TLS_DH_RSA_WITH_DES_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400012B")]
		TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400012C")]
		TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400012D")]
		TLS_DHE_DSS_WITH_DES_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400012E")]
		TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400012F")]
		TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000130")]
		TLS_DHE_RSA_WITH_DES_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000131")]
		TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000132")]
		TLS_DH_anon_EXPORT_WITH_RC4_40_MD5,
		[global::Cpp2ILInjected.Token(Token = "0x4000133")]
		TLS_DH_anon_WITH_RC4_128_MD5,
		[global::Cpp2ILInjected.Token(Token = "0x4000134")]
		TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000135")]
		TLS_DH_anon_WITH_DES_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000136")]
		TLS_DH_anon_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000137")]
		TLS_RSA_WITH_AES_128_CBC_SHA = 47,
		[global::Cpp2ILInjected.Token(Token = "0x4000138")]
		TLS_DH_DSS_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000139")]
		TLS_DH_RSA_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400013A")]
		TLS_DHE_DSS_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400013B")]
		TLS_DHE_RSA_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400013C")]
		TLS_DH_anon_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400013D")]
		TLS_RSA_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400013E")]
		TLS_DH_DSS_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400013F")]
		TLS_DH_RSA_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000140")]
		TLS_DHE_DSS_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000141")]
		TLS_DHE_RSA_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000142")]
		TLS_DH_anon_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000143")]
		TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65,
		[global::Cpp2ILInjected.Token(Token = "0x4000144")]
		TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000145")]
		TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000146")]
		TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000147")]
		TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000148")]
		TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000149")]
		TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132,
		[global::Cpp2ILInjected.Token(Token = "0x400014A")]
		TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400014B")]
		TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400014C")]
		TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400014D")]
		TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400014E")]
		TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400014F")]
		TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186,
		[global::Cpp2ILInjected.Token(Token = "0x4000150")]
		TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000151")]
		TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000152")]
		TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000153")]
		TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000154")]
		TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000155")]
		TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000156")]
		TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000157")]
		TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000158")]
		TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000159")]
		TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x400015A")]
		TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x400015B")]
		TLS_RSA_WITH_SEED_CBC_SHA = 150,
		[global::Cpp2ILInjected.Token(Token = "0x400015C")]
		TLS_DH_DSS_WITH_SEED_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400015D")]
		TLS_DH_RSA_WITH_SEED_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400015E")]
		TLS_DHE_DSS_WITH_SEED_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400015F")]
		TLS_DHE_RSA_WITH_SEED_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000160")]
		TLS_DH_anon_WITH_SEED_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000161")]
		TLS_PSK_WITH_RC4_128_SHA = 138,
		[global::Cpp2ILInjected.Token(Token = "0x4000162")]
		TLS_PSK_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000163")]
		TLS_PSK_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000164")]
		TLS_PSK_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000165")]
		TLS_DHE_PSK_WITH_RC4_128_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000166")]
		TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000167")]
		TLS_DHE_PSK_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000168")]
		TLS_DHE_PSK_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000169")]
		TLS_RSA_PSK_WITH_RC4_128_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400016A")]
		TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400016B")]
		TLS_RSA_PSK_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400016C")]
		TLS_RSA_PSK_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400016D")]
		TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153,
		[global::Cpp2ILInjected.Token(Token = "0x400016E")]
		TLS_ECDH_ECDSA_WITH_RC4_128_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400016F")]
		TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000170")]
		TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000171")]
		TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000172")]
		TLS_ECDHE_ECDSA_WITH_NULL_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000173")]
		TLS_ECDHE_ECDSA_WITH_RC4_128_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000174")]
		TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000175")]
		TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000176")]
		TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000177")]
		TLS_ECDH_RSA_WITH_NULL_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000178")]
		TLS_ECDH_RSA_WITH_RC4_128_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000179")]
		TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400017A")]
		TLS_ECDH_RSA_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400017B")]
		TLS_ECDH_RSA_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400017C")]
		TLS_ECDHE_RSA_WITH_NULL_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400017D")]
		TLS_ECDHE_RSA_WITH_RC4_128_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400017E")]
		TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400017F")]
		TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000180")]
		TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000181")]
		TLS_ECDH_anon_WITH_NULL_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000182")]
		TLS_ECDH_anon_WITH_RC4_128_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000183")]
		TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000184")]
		TLS_ECDH_anon_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000185")]
		TLS_ECDH_anon_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000186")]
		TLS_PSK_WITH_NULL_SHA = 44,
		[global::Cpp2ILInjected.Token(Token = "0x4000187")]
		TLS_DHE_PSK_WITH_NULL_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000188")]
		TLS_RSA_PSK_WITH_NULL_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000189")]
		TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178,
		[global::Cpp2ILInjected.Token(Token = "0x400018A")]
		TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400018B")]
		TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400018C")]
		TLS_SRP_SHA_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400018D")]
		TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400018E")]
		TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x400018F")]
		TLS_SRP_SHA_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000190")]
		TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000191")]
		TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x4000192")]
		TLS_RSA_WITH_NULL_SHA256 = 59,
		[global::Cpp2ILInjected.Token(Token = "0x4000193")]
		TLS_RSA_WITH_AES_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000194")]
		TLS_RSA_WITH_AES_256_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000195")]
		TLS_DH_DSS_WITH_AES_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000196")]
		TLS_DH_RSA_WITH_AES_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000197")]
		TLS_DHE_DSS_WITH_AES_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000198")]
		TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103,
		[global::Cpp2ILInjected.Token(Token = "0x4000199")]
		TLS_DH_DSS_WITH_AES_256_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x400019A")]
		TLS_DH_RSA_WITH_AES_256_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x400019B")]
		TLS_DHE_DSS_WITH_AES_256_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x400019C")]
		TLS_DHE_RSA_WITH_AES_256_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x400019D")]
		TLS_DH_anon_WITH_AES_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x400019E")]
		TLS_DH_anon_WITH_AES_256_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x400019F")]
		TLS_RSA_WITH_AES_128_GCM_SHA256 = 156,
		[global::Cpp2ILInjected.Token(Token = "0x40001A0")]
		TLS_RSA_WITH_AES_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001A1")]
		TLS_DHE_RSA_WITH_AES_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001A2")]
		TLS_DHE_RSA_WITH_AES_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001A3")]
		TLS_DH_RSA_WITH_AES_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001A4")]
		TLS_DH_RSA_WITH_AES_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001A5")]
		TLS_DHE_DSS_WITH_AES_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001A6")]
		TLS_DHE_DSS_WITH_AES_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001A7")]
		TLS_DH_DSS_WITH_AES_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001A8")]
		TLS_DH_DSS_WITH_AES_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001A9")]
		TLS_DH_anon_WITH_AES_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001AA")]
		TLS_DH_anon_WITH_AES_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001AB")]
		TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187,
		[global::Cpp2ILInjected.Token(Token = "0x40001AC")]
		TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001AD")]
		TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001AE")]
		TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001AF")]
		TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001B0")]
		TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001B1")]
		TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001B2")]
		TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001B3")]
		TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001B4")]
		TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001B5")]
		TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001B6")]
		TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001B7")]
		TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001B8")]
		TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001B9")]
		TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001BA")]
		TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001BB")]
		TLS_PSK_WITH_AES_128_GCM_SHA256 = 168,
		[global::Cpp2ILInjected.Token(Token = "0x40001BC")]
		TLS_PSK_WITH_AES_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001BD")]
		TLS_DHE_PSK_WITH_AES_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001BE")]
		TLS_DHE_PSK_WITH_AES_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
		TLS_RSA_PSK_WITH_AES_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
		TLS_RSA_PSK_WITH_AES_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
		TLS_PSK_WITH_AES_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
		TLS_PSK_WITH_AES_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
		TLS_PSK_WITH_NULL_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
		TLS_PSK_WITH_NULL_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001C5")]
		TLS_DHE_PSK_WITH_AES_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001C6")]
		TLS_DHE_PSK_WITH_AES_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001C7")]
		TLS_DHE_PSK_WITH_NULL_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001C8")]
		TLS_DHE_PSK_WITH_NULL_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001C9")]
		TLS_RSA_PSK_WITH_AES_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001CA")]
		TLS_RSA_PSK_WITH_AES_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001CB")]
		TLS_RSA_PSK_WITH_NULL_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001CC")]
		TLS_RSA_PSK_WITH_NULL_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001CD")]
		TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203,
		[global::Cpp2ILInjected.Token(Token = "0x40001CE")]
		TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x40001CF")]
		TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x40001D0")]
		TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x40001D1")]
		TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001D2")]
		TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001D3")]
		TLS_ECDHE_PSK_WITH_NULL_SHA,
		[global::Cpp2ILInjected.Token(Token = "0x40001D4")]
		TLS_ECDHE_PSK_WITH_NULL_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001D5")]
		TLS_ECDHE_PSK_WITH_NULL_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001D6")]
		TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255,
		[global::Cpp2ILInjected.Token(Token = "0x40001D7")]
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266,
		[global::Cpp2ILInjected.Token(Token = "0x40001D8")]
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001D9")]
		TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001DA")]
		TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001DB")]
		TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001DC")]
		TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001DD")]
		TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001DE")]
		TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001DF")]
		TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001E0")]
		TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001E1")]
		TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001E2")]
		TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001E3")]
		TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001E4")]
		TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001E5")]
		TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001E6")]
		TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001E7")]
		TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001E8")]
		TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001E9")]
		TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001EA")]
		TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001EB")]
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001EC")]
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001ED")]
		TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001EE")]
		TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001EF")]
		TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001F0")]
		TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001F1")]
		TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001F2")]
		TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001F3")]
		TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001F4")]
		TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001F5")]
		TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001F6")]
		TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001F7")]
		TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001F8")]
		TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001F9")]
		TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001FA")]
		TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001FB")]
		TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001FC")]
		TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001FD")]
		TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x40001FE")]
		TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x40001FF")]
		TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000200")]
		TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384,
		[global::Cpp2ILInjected.Token(Token = "0x4000201")]
		TLS_RSA_WITH_AES_128_CCM,
		[global::Cpp2ILInjected.Token(Token = "0x4000202")]
		TLS_RSA_WITH_AES_256_CCM,
		[global::Cpp2ILInjected.Token(Token = "0x4000203")]
		TLS_DHE_RSA_WITH_AES_128_CCM,
		[global::Cpp2ILInjected.Token(Token = "0x4000204")]
		TLS_DHE_RSA_WITH_AES_256_CCM,
		[global::Cpp2ILInjected.Token(Token = "0x4000205")]
		TLS_RSA_WITH_AES_128_CCM_8,
		[global::Cpp2ILInjected.Token(Token = "0x4000206")]
		TLS_RSA_WITH_AES_256_CCM_8,
		[global::Cpp2ILInjected.Token(Token = "0x4000207")]
		TLS_DHE_RSA_WITH_AES_128_CCM_8,
		[global::Cpp2ILInjected.Token(Token = "0x4000208")]
		TLS_DHE_RSA_WITH_AES_256_CCM_8,
		[global::Cpp2ILInjected.Token(Token = "0x4000209")]
		TLS_PSK_WITH_AES_128_CCM,
		[global::Cpp2ILInjected.Token(Token = "0x400020A")]
		TLS_PSK_WITH_AES_256_CCM,
		[global::Cpp2ILInjected.Token(Token = "0x400020B")]
		TLS_DHE_PSK_WITH_AES_128_CCM,
		[global::Cpp2ILInjected.Token(Token = "0x400020C")]
		TLS_DHE_PSK_WITH_AES_256_CCM,
		[global::Cpp2ILInjected.Token(Token = "0x400020D")]
		TLS_PSK_WITH_AES_128_CCM_8,
		[global::Cpp2ILInjected.Token(Token = "0x400020E")]
		TLS_PSK_WITH_AES_256_CCM_8,
		[global::Cpp2ILInjected.Token(Token = "0x400020F")]
		TLS_PSK_DHE_WITH_AES_128_CCM_8,
		[global::Cpp2ILInjected.Token(Token = "0x4000210")]
		TLS_PSK_DHE_WITH_AES_256_CCM_8,
		[global::Cpp2ILInjected.Token(Token = "0x4000211")]
		TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52243,
		[global::Cpp2ILInjected.Token(Token = "0x4000212")]
		TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000213")]
		TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256,
		[global::Cpp2ILInjected.Token(Token = "0x4000214")]
		TLS_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58384,
		[global::Cpp2ILInjected.Token(Token = "0x4000215")]
		TLS_RSA_WITH_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x4000216")]
		TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x4000217")]
		TLS_ECDHE_RSA_WITH_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x4000218")]
		TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x4000219")]
		TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x400021A")]
		TLS_PSK_WITH_ESTREAM_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x400021B")]
		TLS_PSK_WITH_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x400021C")]
		TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x400021D")]
		TLS_ECDHE_PSK_WITH_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x400021E")]
		TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x400021F")]
		TLS_RSA_PSK_WITH_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x4000220")]
		TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x4000221")]
		TLS_DHE_PSK_WITH_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x4000222")]
		TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x4000223")]
		TLS_DHE_RSA_WITH_SALSA20_SHA1,
		[global::Cpp2ILInjected.Token(Token = "0x4000224")]
		TLS_FALLBACK_SCSV = 22016
	}
}
