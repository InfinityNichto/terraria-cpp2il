using System;
using Cpp2ILInjected;

namespace Mono.Security.Interface
{
	// Token: 0x0200002C RID: 44
	[CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000047")]
	public enum CipherSuiteCode : ushort
	{
		// Token: 0x040000EE RID: 238
		[global::Cpp2ILInjected.Token(Token = "0x400011B")]
		TLS_NULL_WITH_NULL_NULL,
		// Token: 0x040000EF RID: 239
		[global::Cpp2ILInjected.Token(Token = "0x400011C")]
		TLS_RSA_WITH_NULL_MD5,
		// Token: 0x040000F0 RID: 240
		[global::Cpp2ILInjected.Token(Token = "0x400011D")]
		TLS_RSA_WITH_NULL_SHA,
		// Token: 0x040000F1 RID: 241
		[global::Cpp2ILInjected.Token(Token = "0x400011E")]
		TLS_RSA_EXPORT_WITH_RC4_40_MD5,
		// Token: 0x040000F2 RID: 242
		[global::Cpp2ILInjected.Token(Token = "0x400011F")]
		TLS_RSA_WITH_RC4_128_MD5,
		// Token: 0x040000F3 RID: 243
		[global::Cpp2ILInjected.Token(Token = "0x4000120")]
		TLS_RSA_WITH_RC4_128_SHA,
		// Token: 0x040000F4 RID: 244
		[global::Cpp2ILInjected.Token(Token = "0x4000121")]
		TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5,
		// Token: 0x040000F5 RID: 245
		[global::Cpp2ILInjected.Token(Token = "0x4000122")]
		TLS_RSA_WITH_IDEA_CBC_SHA,
		// Token: 0x040000F6 RID: 246
		[global::Cpp2ILInjected.Token(Token = "0x4000123")]
		TLS_RSA_EXPORT_WITH_DES40_CBC_SHA,
		// Token: 0x040000F7 RID: 247
		[global::Cpp2ILInjected.Token(Token = "0x4000124")]
		TLS_RSA_WITH_DES_CBC_SHA,
		// Token: 0x040000F8 RID: 248
		[global::Cpp2ILInjected.Token(Token = "0x4000125")]
		TLS_RSA_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x040000F9 RID: 249
		[global::Cpp2ILInjected.Token(Token = "0x4000126")]
		TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA,
		// Token: 0x040000FA RID: 250
		[global::Cpp2ILInjected.Token(Token = "0x4000127")]
		TLS_DH_DSS_WITH_DES_CBC_SHA,
		// Token: 0x040000FB RID: 251
		[global::Cpp2ILInjected.Token(Token = "0x4000128")]
		TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x040000FC RID: 252
		[global::Cpp2ILInjected.Token(Token = "0x4000129")]
		TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA,
		// Token: 0x040000FD RID: 253
		[global::Cpp2ILInjected.Token(Token = "0x400012A")]
		TLS_DH_RSA_WITH_DES_CBC_SHA,
		// Token: 0x040000FE RID: 254
		[global::Cpp2ILInjected.Token(Token = "0x400012B")]
		TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x040000FF RID: 255
		[global::Cpp2ILInjected.Token(Token = "0x400012C")]
		TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA,
		// Token: 0x04000100 RID: 256
		[global::Cpp2ILInjected.Token(Token = "0x400012D")]
		TLS_DHE_DSS_WITH_DES_CBC_SHA,
		// Token: 0x04000101 RID: 257
		[global::Cpp2ILInjected.Token(Token = "0x400012E")]
		TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x04000102 RID: 258
		[global::Cpp2ILInjected.Token(Token = "0x400012F")]
		TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA,
		// Token: 0x04000103 RID: 259
		[global::Cpp2ILInjected.Token(Token = "0x4000130")]
		TLS_DHE_RSA_WITH_DES_CBC_SHA,
		// Token: 0x04000104 RID: 260
		[global::Cpp2ILInjected.Token(Token = "0x4000131")]
		TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x04000105 RID: 261
		[global::Cpp2ILInjected.Token(Token = "0x4000132")]
		TLS_DH_anon_EXPORT_WITH_RC4_40_MD5,
		// Token: 0x04000106 RID: 262
		[global::Cpp2ILInjected.Token(Token = "0x4000133")]
		TLS_DH_anon_WITH_RC4_128_MD5,
		// Token: 0x04000107 RID: 263
		[global::Cpp2ILInjected.Token(Token = "0x4000134")]
		TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA,
		// Token: 0x04000108 RID: 264
		[global::Cpp2ILInjected.Token(Token = "0x4000135")]
		TLS_DH_anon_WITH_DES_CBC_SHA,
		// Token: 0x04000109 RID: 265
		[global::Cpp2ILInjected.Token(Token = "0x4000136")]
		TLS_DH_anon_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x0400010A RID: 266
		[global::Cpp2ILInjected.Token(Token = "0x4000137")]
		TLS_RSA_WITH_AES_128_CBC_SHA = 47,
		// Token: 0x0400010B RID: 267
		[global::Cpp2ILInjected.Token(Token = "0x4000138")]
		TLS_DH_DSS_WITH_AES_128_CBC_SHA,
		// Token: 0x0400010C RID: 268
		[global::Cpp2ILInjected.Token(Token = "0x4000139")]
		TLS_DH_RSA_WITH_AES_128_CBC_SHA,
		// Token: 0x0400010D RID: 269
		[global::Cpp2ILInjected.Token(Token = "0x400013A")]
		TLS_DHE_DSS_WITH_AES_128_CBC_SHA,
		// Token: 0x0400010E RID: 270
		[global::Cpp2ILInjected.Token(Token = "0x400013B")]
		TLS_DHE_RSA_WITH_AES_128_CBC_SHA,
		// Token: 0x0400010F RID: 271
		[global::Cpp2ILInjected.Token(Token = "0x400013C")]
		TLS_DH_anon_WITH_AES_128_CBC_SHA,
		// Token: 0x04000110 RID: 272
		[global::Cpp2ILInjected.Token(Token = "0x400013D")]
		TLS_RSA_WITH_AES_256_CBC_SHA,
		// Token: 0x04000111 RID: 273
		[global::Cpp2ILInjected.Token(Token = "0x400013E")]
		TLS_DH_DSS_WITH_AES_256_CBC_SHA,
		// Token: 0x04000112 RID: 274
		[global::Cpp2ILInjected.Token(Token = "0x400013F")]
		TLS_DH_RSA_WITH_AES_256_CBC_SHA,
		// Token: 0x04000113 RID: 275
		[global::Cpp2ILInjected.Token(Token = "0x4000140")]
		TLS_DHE_DSS_WITH_AES_256_CBC_SHA,
		// Token: 0x04000114 RID: 276
		[global::Cpp2ILInjected.Token(Token = "0x4000141")]
		TLS_DHE_RSA_WITH_AES_256_CBC_SHA,
		// Token: 0x04000115 RID: 277
		[global::Cpp2ILInjected.Token(Token = "0x4000142")]
		TLS_DH_anon_WITH_AES_256_CBC_SHA,
		// Token: 0x04000116 RID: 278
		[global::Cpp2ILInjected.Token(Token = "0x4000143")]
		TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65,
		// Token: 0x04000117 RID: 279
		[global::Cpp2ILInjected.Token(Token = "0x4000144")]
		TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA,
		// Token: 0x04000118 RID: 280
		[global::Cpp2ILInjected.Token(Token = "0x4000145")]
		TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA,
		// Token: 0x04000119 RID: 281
		[global::Cpp2ILInjected.Token(Token = "0x4000146")]
		TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA,
		// Token: 0x0400011A RID: 282
		[global::Cpp2ILInjected.Token(Token = "0x4000147")]
		TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA,
		// Token: 0x0400011B RID: 283
		[global::Cpp2ILInjected.Token(Token = "0x4000148")]
		TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA,
		// Token: 0x0400011C RID: 284
		[global::Cpp2ILInjected.Token(Token = "0x4000149")]
		TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132,
		// Token: 0x0400011D RID: 285
		[global::Cpp2ILInjected.Token(Token = "0x400014A")]
		TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA,
		// Token: 0x0400011E RID: 286
		[global::Cpp2ILInjected.Token(Token = "0x400014B")]
		TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA,
		// Token: 0x0400011F RID: 287
		[global::Cpp2ILInjected.Token(Token = "0x400014C")]
		TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA,
		// Token: 0x04000120 RID: 288
		[global::Cpp2ILInjected.Token(Token = "0x400014D")]
		TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA,
		// Token: 0x04000121 RID: 289
		[global::Cpp2ILInjected.Token(Token = "0x400014E")]
		TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA,
		// Token: 0x04000122 RID: 290
		[global::Cpp2ILInjected.Token(Token = "0x400014F")]
		TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186,
		// Token: 0x04000123 RID: 291
		[global::Cpp2ILInjected.Token(Token = "0x4000150")]
		TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256,
		// Token: 0x04000124 RID: 292
		[global::Cpp2ILInjected.Token(Token = "0x4000151")]
		TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256,
		// Token: 0x04000125 RID: 293
		[global::Cpp2ILInjected.Token(Token = "0x4000152")]
		TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256,
		// Token: 0x04000126 RID: 294
		[global::Cpp2ILInjected.Token(Token = "0x4000153")]
		TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256,
		// Token: 0x04000127 RID: 295
		[global::Cpp2ILInjected.Token(Token = "0x4000154")]
		TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256,
		// Token: 0x04000128 RID: 296
		[global::Cpp2ILInjected.Token(Token = "0x4000155")]
		TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256,
		// Token: 0x04000129 RID: 297
		[global::Cpp2ILInjected.Token(Token = "0x4000156")]
		TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256,
		// Token: 0x0400012A RID: 298
		[global::Cpp2ILInjected.Token(Token = "0x4000157")]
		TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256,
		// Token: 0x0400012B RID: 299
		[global::Cpp2ILInjected.Token(Token = "0x4000158")]
		TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256,
		// Token: 0x0400012C RID: 300
		[global::Cpp2ILInjected.Token(Token = "0x4000159")]
		TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256,
		// Token: 0x0400012D RID: 301
		[global::Cpp2ILInjected.Token(Token = "0x400015A")]
		TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256,
		// Token: 0x0400012E RID: 302
		[global::Cpp2ILInjected.Token(Token = "0x400015B")]
		TLS_RSA_WITH_SEED_CBC_SHA = 150,
		// Token: 0x0400012F RID: 303
		[global::Cpp2ILInjected.Token(Token = "0x400015C")]
		TLS_DH_DSS_WITH_SEED_CBC_SHA,
		// Token: 0x04000130 RID: 304
		[global::Cpp2ILInjected.Token(Token = "0x400015D")]
		TLS_DH_RSA_WITH_SEED_CBC_SHA,
		// Token: 0x04000131 RID: 305
		[global::Cpp2ILInjected.Token(Token = "0x400015E")]
		TLS_DHE_DSS_WITH_SEED_CBC_SHA,
		// Token: 0x04000132 RID: 306
		[global::Cpp2ILInjected.Token(Token = "0x400015F")]
		TLS_DHE_RSA_WITH_SEED_CBC_SHA,
		// Token: 0x04000133 RID: 307
		[global::Cpp2ILInjected.Token(Token = "0x4000160")]
		TLS_DH_anon_WITH_SEED_CBC_SHA,
		// Token: 0x04000134 RID: 308
		[global::Cpp2ILInjected.Token(Token = "0x4000161")]
		TLS_PSK_WITH_RC4_128_SHA = 138,
		// Token: 0x04000135 RID: 309
		[global::Cpp2ILInjected.Token(Token = "0x4000162")]
		TLS_PSK_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x04000136 RID: 310
		[global::Cpp2ILInjected.Token(Token = "0x4000163")]
		TLS_PSK_WITH_AES_128_CBC_SHA,
		// Token: 0x04000137 RID: 311
		[global::Cpp2ILInjected.Token(Token = "0x4000164")]
		TLS_PSK_WITH_AES_256_CBC_SHA,
		// Token: 0x04000138 RID: 312
		[global::Cpp2ILInjected.Token(Token = "0x4000165")]
		TLS_DHE_PSK_WITH_RC4_128_SHA,
		// Token: 0x04000139 RID: 313
		[global::Cpp2ILInjected.Token(Token = "0x4000166")]
		TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x0400013A RID: 314
		[global::Cpp2ILInjected.Token(Token = "0x4000167")]
		TLS_DHE_PSK_WITH_AES_128_CBC_SHA,
		// Token: 0x0400013B RID: 315
		[global::Cpp2ILInjected.Token(Token = "0x4000168")]
		TLS_DHE_PSK_WITH_AES_256_CBC_SHA,
		// Token: 0x0400013C RID: 316
		[global::Cpp2ILInjected.Token(Token = "0x4000169")]
		TLS_RSA_PSK_WITH_RC4_128_SHA,
		// Token: 0x0400013D RID: 317
		[global::Cpp2ILInjected.Token(Token = "0x400016A")]
		TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x0400013E RID: 318
		[global::Cpp2ILInjected.Token(Token = "0x400016B")]
		TLS_RSA_PSK_WITH_AES_128_CBC_SHA,
		// Token: 0x0400013F RID: 319
		[global::Cpp2ILInjected.Token(Token = "0x400016C")]
		TLS_RSA_PSK_WITH_AES_256_CBC_SHA,
		// Token: 0x04000140 RID: 320
		[global::Cpp2ILInjected.Token(Token = "0x400016D")]
		TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153,
		// Token: 0x04000141 RID: 321
		[global::Cpp2ILInjected.Token(Token = "0x400016E")]
		TLS_ECDH_ECDSA_WITH_RC4_128_SHA,
		// Token: 0x04000142 RID: 322
		[global::Cpp2ILInjected.Token(Token = "0x400016F")]
		TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x04000143 RID: 323
		[global::Cpp2ILInjected.Token(Token = "0x4000170")]
		TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA,
		// Token: 0x04000144 RID: 324
		[global::Cpp2ILInjected.Token(Token = "0x4000171")]
		TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA,
		// Token: 0x04000145 RID: 325
		[global::Cpp2ILInjected.Token(Token = "0x4000172")]
		TLS_ECDHE_ECDSA_WITH_NULL_SHA,
		// Token: 0x04000146 RID: 326
		[global::Cpp2ILInjected.Token(Token = "0x4000173")]
		TLS_ECDHE_ECDSA_WITH_RC4_128_SHA,
		// Token: 0x04000147 RID: 327
		[global::Cpp2ILInjected.Token(Token = "0x4000174")]
		TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x04000148 RID: 328
		[global::Cpp2ILInjected.Token(Token = "0x4000175")]
		TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA,
		// Token: 0x04000149 RID: 329
		[global::Cpp2ILInjected.Token(Token = "0x4000176")]
		TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA,
		// Token: 0x0400014A RID: 330
		[global::Cpp2ILInjected.Token(Token = "0x4000177")]
		TLS_ECDH_RSA_WITH_NULL_SHA,
		// Token: 0x0400014B RID: 331
		[global::Cpp2ILInjected.Token(Token = "0x4000178")]
		TLS_ECDH_RSA_WITH_RC4_128_SHA,
		// Token: 0x0400014C RID: 332
		[global::Cpp2ILInjected.Token(Token = "0x4000179")]
		TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x0400014D RID: 333
		[global::Cpp2ILInjected.Token(Token = "0x400017A")]
		TLS_ECDH_RSA_WITH_AES_128_CBC_SHA,
		// Token: 0x0400014E RID: 334
		[global::Cpp2ILInjected.Token(Token = "0x400017B")]
		TLS_ECDH_RSA_WITH_AES_256_CBC_SHA,
		// Token: 0x0400014F RID: 335
		[global::Cpp2ILInjected.Token(Token = "0x400017C")]
		TLS_ECDHE_RSA_WITH_NULL_SHA,
		// Token: 0x04000150 RID: 336
		[global::Cpp2ILInjected.Token(Token = "0x400017D")]
		TLS_ECDHE_RSA_WITH_RC4_128_SHA,
		// Token: 0x04000151 RID: 337
		[global::Cpp2ILInjected.Token(Token = "0x400017E")]
		TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x04000152 RID: 338
		[global::Cpp2ILInjected.Token(Token = "0x400017F")]
		TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA,
		// Token: 0x04000153 RID: 339
		[global::Cpp2ILInjected.Token(Token = "0x4000180")]
		TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA,
		// Token: 0x04000154 RID: 340
		[global::Cpp2ILInjected.Token(Token = "0x4000181")]
		TLS_ECDH_anon_WITH_NULL_SHA,
		// Token: 0x04000155 RID: 341
		[global::Cpp2ILInjected.Token(Token = "0x4000182")]
		TLS_ECDH_anon_WITH_RC4_128_SHA,
		// Token: 0x04000156 RID: 342
		[global::Cpp2ILInjected.Token(Token = "0x4000183")]
		TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x04000157 RID: 343
		[global::Cpp2ILInjected.Token(Token = "0x4000184")]
		TLS_ECDH_anon_WITH_AES_128_CBC_SHA,
		// Token: 0x04000158 RID: 344
		[global::Cpp2ILInjected.Token(Token = "0x4000185")]
		TLS_ECDH_anon_WITH_AES_256_CBC_SHA,
		// Token: 0x04000159 RID: 345
		[global::Cpp2ILInjected.Token(Token = "0x4000186")]
		TLS_PSK_WITH_NULL_SHA = 44,
		// Token: 0x0400015A RID: 346
		[global::Cpp2ILInjected.Token(Token = "0x4000187")]
		TLS_DHE_PSK_WITH_NULL_SHA,
		// Token: 0x0400015B RID: 347
		[global::Cpp2ILInjected.Token(Token = "0x4000188")]
		TLS_RSA_PSK_WITH_NULL_SHA,
		// Token: 0x0400015C RID: 348
		[global::Cpp2ILInjected.Token(Token = "0x4000189")]
		TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178,
		// Token: 0x0400015D RID: 349
		[global::Cpp2ILInjected.Token(Token = "0x400018A")]
		TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x0400015E RID: 350
		[global::Cpp2ILInjected.Token(Token = "0x400018B")]
		TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x0400015F RID: 351
		[global::Cpp2ILInjected.Token(Token = "0x400018C")]
		TLS_SRP_SHA_WITH_AES_128_CBC_SHA,
		// Token: 0x04000160 RID: 352
		[global::Cpp2ILInjected.Token(Token = "0x400018D")]
		TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA,
		// Token: 0x04000161 RID: 353
		[global::Cpp2ILInjected.Token(Token = "0x400018E")]
		TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA,
		// Token: 0x04000162 RID: 354
		[global::Cpp2ILInjected.Token(Token = "0x400018F")]
		TLS_SRP_SHA_WITH_AES_256_CBC_SHA,
		// Token: 0x04000163 RID: 355
		[global::Cpp2ILInjected.Token(Token = "0x4000190")]
		TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA,
		// Token: 0x04000164 RID: 356
		[global::Cpp2ILInjected.Token(Token = "0x4000191")]
		TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA,
		// Token: 0x04000165 RID: 357
		[global::Cpp2ILInjected.Token(Token = "0x4000192")]
		TLS_RSA_WITH_NULL_SHA256 = 59,
		// Token: 0x04000166 RID: 358
		[global::Cpp2ILInjected.Token(Token = "0x4000193")]
		TLS_RSA_WITH_AES_128_CBC_SHA256,
		// Token: 0x04000167 RID: 359
		[global::Cpp2ILInjected.Token(Token = "0x4000194")]
		TLS_RSA_WITH_AES_256_CBC_SHA256,
		// Token: 0x04000168 RID: 360
		[global::Cpp2ILInjected.Token(Token = "0x4000195")]
		TLS_DH_DSS_WITH_AES_128_CBC_SHA256,
		// Token: 0x04000169 RID: 361
		[global::Cpp2ILInjected.Token(Token = "0x4000196")]
		TLS_DH_RSA_WITH_AES_128_CBC_SHA256,
		// Token: 0x0400016A RID: 362
		[global::Cpp2ILInjected.Token(Token = "0x4000197")]
		TLS_DHE_DSS_WITH_AES_128_CBC_SHA256,
		// Token: 0x0400016B RID: 363
		[global::Cpp2ILInjected.Token(Token = "0x4000198")]
		TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103,
		// Token: 0x0400016C RID: 364
		[global::Cpp2ILInjected.Token(Token = "0x4000199")]
		TLS_DH_DSS_WITH_AES_256_CBC_SHA256,
		// Token: 0x0400016D RID: 365
		[global::Cpp2ILInjected.Token(Token = "0x400019A")]
		TLS_DH_RSA_WITH_AES_256_CBC_SHA256,
		// Token: 0x0400016E RID: 366
		[global::Cpp2ILInjected.Token(Token = "0x400019B")]
		TLS_DHE_DSS_WITH_AES_256_CBC_SHA256,
		// Token: 0x0400016F RID: 367
		[global::Cpp2ILInjected.Token(Token = "0x400019C")]
		TLS_DHE_RSA_WITH_AES_256_CBC_SHA256,
		// Token: 0x04000170 RID: 368
		[global::Cpp2ILInjected.Token(Token = "0x400019D")]
		TLS_DH_anon_WITH_AES_128_CBC_SHA256,
		// Token: 0x04000171 RID: 369
		[global::Cpp2ILInjected.Token(Token = "0x400019E")]
		TLS_DH_anon_WITH_AES_256_CBC_SHA256,
		// Token: 0x04000172 RID: 370
		[global::Cpp2ILInjected.Token(Token = "0x400019F")]
		TLS_RSA_WITH_AES_128_GCM_SHA256 = 156,
		// Token: 0x04000173 RID: 371
		[global::Cpp2ILInjected.Token(Token = "0x40001A0")]
		TLS_RSA_WITH_AES_256_GCM_SHA384,
		// Token: 0x04000174 RID: 372
		[global::Cpp2ILInjected.Token(Token = "0x40001A1")]
		TLS_DHE_RSA_WITH_AES_128_GCM_SHA256,
		// Token: 0x04000175 RID: 373
		[global::Cpp2ILInjected.Token(Token = "0x40001A2")]
		TLS_DHE_RSA_WITH_AES_256_GCM_SHA384,
		// Token: 0x04000176 RID: 374
		[global::Cpp2ILInjected.Token(Token = "0x40001A3")]
		TLS_DH_RSA_WITH_AES_128_GCM_SHA256,
		// Token: 0x04000177 RID: 375
		[global::Cpp2ILInjected.Token(Token = "0x40001A4")]
		TLS_DH_RSA_WITH_AES_256_GCM_SHA384,
		// Token: 0x04000178 RID: 376
		[global::Cpp2ILInjected.Token(Token = "0x40001A5")]
		TLS_DHE_DSS_WITH_AES_128_GCM_SHA256,
		// Token: 0x04000179 RID: 377
		[global::Cpp2ILInjected.Token(Token = "0x40001A6")]
		TLS_DHE_DSS_WITH_AES_256_GCM_SHA384,
		// Token: 0x0400017A RID: 378
		[global::Cpp2ILInjected.Token(Token = "0x40001A7")]
		TLS_DH_DSS_WITH_AES_128_GCM_SHA256,
		// Token: 0x0400017B RID: 379
		[global::Cpp2ILInjected.Token(Token = "0x40001A8")]
		TLS_DH_DSS_WITH_AES_256_GCM_SHA384,
		// Token: 0x0400017C RID: 380
		[global::Cpp2ILInjected.Token(Token = "0x40001A9")]
		TLS_DH_anon_WITH_AES_128_GCM_SHA256,
		// Token: 0x0400017D RID: 381
		[global::Cpp2ILInjected.Token(Token = "0x40001AA")]
		TLS_DH_anon_WITH_AES_256_GCM_SHA384,
		// Token: 0x0400017E RID: 382
		[global::Cpp2ILInjected.Token(Token = "0x40001AB")]
		TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187,
		// Token: 0x0400017F RID: 383
		[global::Cpp2ILInjected.Token(Token = "0x40001AC")]
		TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,
		// Token: 0x04000180 RID: 384
		[global::Cpp2ILInjected.Token(Token = "0x40001AD")]
		TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256,
		// Token: 0x04000181 RID: 385
		[global::Cpp2ILInjected.Token(Token = "0x40001AE")]
		TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384,
		// Token: 0x04000182 RID: 386
		[global::Cpp2ILInjected.Token(Token = "0x40001AF")]
		TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256,
		// Token: 0x04000183 RID: 387
		[global::Cpp2ILInjected.Token(Token = "0x40001B0")]
		TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,
		// Token: 0x04000184 RID: 388
		[global::Cpp2ILInjected.Token(Token = "0x40001B1")]
		TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256,
		// Token: 0x04000185 RID: 389
		[global::Cpp2ILInjected.Token(Token = "0x40001B2")]
		TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384,
		// Token: 0x04000186 RID: 390
		[global::Cpp2ILInjected.Token(Token = "0x40001B3")]
		TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,
		// Token: 0x04000187 RID: 391
		[global::Cpp2ILInjected.Token(Token = "0x40001B4")]
		TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,
		// Token: 0x04000188 RID: 392
		[global::Cpp2ILInjected.Token(Token = "0x40001B5")]
		TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256,
		// Token: 0x04000189 RID: 393
		[global::Cpp2ILInjected.Token(Token = "0x40001B6")]
		TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384,
		// Token: 0x0400018A RID: 394
		[global::Cpp2ILInjected.Token(Token = "0x40001B7")]
		TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,
		// Token: 0x0400018B RID: 395
		[global::Cpp2ILInjected.Token(Token = "0x40001B8")]
		TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,
		// Token: 0x0400018C RID: 396
		[global::Cpp2ILInjected.Token(Token = "0x40001B9")]
		TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256,
		// Token: 0x0400018D RID: 397
		[global::Cpp2ILInjected.Token(Token = "0x40001BA")]
		TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384,
		// Token: 0x0400018E RID: 398
		[global::Cpp2ILInjected.Token(Token = "0x40001BB")]
		TLS_PSK_WITH_AES_128_GCM_SHA256 = 168,
		// Token: 0x0400018F RID: 399
		[global::Cpp2ILInjected.Token(Token = "0x40001BC")]
		TLS_PSK_WITH_AES_256_GCM_SHA384,
		// Token: 0x04000190 RID: 400
		[global::Cpp2ILInjected.Token(Token = "0x40001BD")]
		TLS_DHE_PSK_WITH_AES_128_GCM_SHA256,
		// Token: 0x04000191 RID: 401
		[global::Cpp2ILInjected.Token(Token = "0x40001BE")]
		TLS_DHE_PSK_WITH_AES_256_GCM_SHA384,
		// Token: 0x04000192 RID: 402
		[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
		TLS_RSA_PSK_WITH_AES_128_GCM_SHA256,
		// Token: 0x04000193 RID: 403
		[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
		TLS_RSA_PSK_WITH_AES_256_GCM_SHA384,
		// Token: 0x04000194 RID: 404
		[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
		TLS_PSK_WITH_AES_128_CBC_SHA256,
		// Token: 0x04000195 RID: 405
		[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
		TLS_PSK_WITH_AES_256_CBC_SHA384,
		// Token: 0x04000196 RID: 406
		[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
		TLS_PSK_WITH_NULL_SHA256,
		// Token: 0x04000197 RID: 407
		[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
		TLS_PSK_WITH_NULL_SHA384,
		// Token: 0x04000198 RID: 408
		[global::Cpp2ILInjected.Token(Token = "0x40001C5")]
		TLS_DHE_PSK_WITH_AES_128_CBC_SHA256,
		// Token: 0x04000199 RID: 409
		[global::Cpp2ILInjected.Token(Token = "0x40001C6")]
		TLS_DHE_PSK_WITH_AES_256_CBC_SHA384,
		// Token: 0x0400019A RID: 410
		[global::Cpp2ILInjected.Token(Token = "0x40001C7")]
		TLS_DHE_PSK_WITH_NULL_SHA256,
		// Token: 0x0400019B RID: 411
		[global::Cpp2ILInjected.Token(Token = "0x40001C8")]
		TLS_DHE_PSK_WITH_NULL_SHA384,
		// Token: 0x0400019C RID: 412
		[global::Cpp2ILInjected.Token(Token = "0x40001C9")]
		TLS_RSA_PSK_WITH_AES_128_CBC_SHA256,
		// Token: 0x0400019D RID: 413
		[global::Cpp2ILInjected.Token(Token = "0x40001CA")]
		TLS_RSA_PSK_WITH_AES_256_CBC_SHA384,
		// Token: 0x0400019E RID: 414
		[global::Cpp2ILInjected.Token(Token = "0x40001CB")]
		TLS_RSA_PSK_WITH_NULL_SHA256,
		// Token: 0x0400019F RID: 415
		[global::Cpp2ILInjected.Token(Token = "0x40001CC")]
		TLS_RSA_PSK_WITH_NULL_SHA384,
		// Token: 0x040001A0 RID: 416
		[global::Cpp2ILInjected.Token(Token = "0x40001CD")]
		TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203,
		// Token: 0x040001A1 RID: 417
		[global::Cpp2ILInjected.Token(Token = "0x40001CE")]
		TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA,
		// Token: 0x040001A2 RID: 418
		[global::Cpp2ILInjected.Token(Token = "0x40001CF")]
		TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA,
		// Token: 0x040001A3 RID: 419
		[global::Cpp2ILInjected.Token(Token = "0x40001D0")]
		TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA,
		// Token: 0x040001A4 RID: 420
		[global::Cpp2ILInjected.Token(Token = "0x40001D1")]
		TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256,
		// Token: 0x040001A5 RID: 421
		[global::Cpp2ILInjected.Token(Token = "0x40001D2")]
		TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384,
		// Token: 0x040001A6 RID: 422
		[global::Cpp2ILInjected.Token(Token = "0x40001D3")]
		TLS_ECDHE_PSK_WITH_NULL_SHA,
		// Token: 0x040001A7 RID: 423
		[global::Cpp2ILInjected.Token(Token = "0x40001D4")]
		TLS_ECDHE_PSK_WITH_NULL_SHA256,
		// Token: 0x040001A8 RID: 424
		[global::Cpp2ILInjected.Token(Token = "0x40001D5")]
		TLS_ECDHE_PSK_WITH_NULL_SHA384,
		// Token: 0x040001A9 RID: 425
		[global::Cpp2ILInjected.Token(Token = "0x40001D6")]
		TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255,
		// Token: 0x040001AA RID: 426
		[global::Cpp2ILInjected.Token(Token = "0x40001D7")]
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266,
		// Token: 0x040001AB RID: 427
		[global::Cpp2ILInjected.Token(Token = "0x40001D8")]
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384,
		// Token: 0x040001AC RID: 428
		[global::Cpp2ILInjected.Token(Token = "0x40001D9")]
		TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256,
		// Token: 0x040001AD RID: 429
		[global::Cpp2ILInjected.Token(Token = "0x40001DA")]
		TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384,
		// Token: 0x040001AE RID: 430
		[global::Cpp2ILInjected.Token(Token = "0x40001DB")]
		TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256,
		// Token: 0x040001AF RID: 431
		[global::Cpp2ILInjected.Token(Token = "0x40001DC")]
		TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384,
		// Token: 0x040001B0 RID: 432
		[global::Cpp2ILInjected.Token(Token = "0x40001DD")]
		TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256,
		// Token: 0x040001B1 RID: 433
		[global::Cpp2ILInjected.Token(Token = "0x40001DE")]
		TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384,
		// Token: 0x040001B2 RID: 434
		[global::Cpp2ILInjected.Token(Token = "0x40001DF")]
		TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256,
		// Token: 0x040001B3 RID: 435
		[global::Cpp2ILInjected.Token(Token = "0x40001E0")]
		TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384,
		// Token: 0x040001B4 RID: 436
		[global::Cpp2ILInjected.Token(Token = "0x40001E1")]
		TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256,
		// Token: 0x040001B5 RID: 437
		[global::Cpp2ILInjected.Token(Token = "0x40001E2")]
		TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384,
		// Token: 0x040001B6 RID: 438
		[global::Cpp2ILInjected.Token(Token = "0x40001E3")]
		TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256,
		// Token: 0x040001B7 RID: 439
		[global::Cpp2ILInjected.Token(Token = "0x40001E4")]
		TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384,
		// Token: 0x040001B8 RID: 440
		[global::Cpp2ILInjected.Token(Token = "0x40001E5")]
		TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256,
		// Token: 0x040001B9 RID: 441
		[global::Cpp2ILInjected.Token(Token = "0x40001E6")]
		TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384,
		// Token: 0x040001BA RID: 442
		[global::Cpp2ILInjected.Token(Token = "0x40001E7")]
		TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256,
		// Token: 0x040001BB RID: 443
		[global::Cpp2ILInjected.Token(Token = "0x40001E8")]
		TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384,
		// Token: 0x040001BC RID: 444
		[global::Cpp2ILInjected.Token(Token = "0x40001E9")]
		TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256,
		// Token: 0x040001BD RID: 445
		[global::Cpp2ILInjected.Token(Token = "0x40001EA")]
		TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384,
		// Token: 0x040001BE RID: 446
		[global::Cpp2ILInjected.Token(Token = "0x40001EB")]
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256,
		// Token: 0x040001BF RID: 447
		[global::Cpp2ILInjected.Token(Token = "0x40001EC")]
		TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384,
		// Token: 0x040001C0 RID: 448
		[global::Cpp2ILInjected.Token(Token = "0x40001ED")]
		TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256,
		// Token: 0x040001C1 RID: 449
		[global::Cpp2ILInjected.Token(Token = "0x40001EE")]
		TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384,
		// Token: 0x040001C2 RID: 450
		[global::Cpp2ILInjected.Token(Token = "0x40001EF")]
		TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256,
		// Token: 0x040001C3 RID: 451
		[global::Cpp2ILInjected.Token(Token = "0x40001F0")]
		TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384,
		// Token: 0x040001C4 RID: 452
		[global::Cpp2ILInjected.Token(Token = "0x40001F1")]
		TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256,
		// Token: 0x040001C5 RID: 453
		[global::Cpp2ILInjected.Token(Token = "0x40001F2")]
		TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384,
		// Token: 0x040001C6 RID: 454
		[global::Cpp2ILInjected.Token(Token = "0x40001F3")]
		TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256,
		// Token: 0x040001C7 RID: 455
		[global::Cpp2ILInjected.Token(Token = "0x40001F4")]
		TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384,
		// Token: 0x040001C8 RID: 456
		[global::Cpp2ILInjected.Token(Token = "0x40001F5")]
		TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256,
		// Token: 0x040001C9 RID: 457
		[global::Cpp2ILInjected.Token(Token = "0x40001F6")]
		TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384,
		// Token: 0x040001CA RID: 458
		[global::Cpp2ILInjected.Token(Token = "0x40001F7")]
		TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256,
		// Token: 0x040001CB RID: 459
		[global::Cpp2ILInjected.Token(Token = "0x40001F8")]
		TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384,
		// Token: 0x040001CC RID: 460
		[global::Cpp2ILInjected.Token(Token = "0x40001F9")]
		TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256,
		// Token: 0x040001CD RID: 461
		[global::Cpp2ILInjected.Token(Token = "0x40001FA")]
		TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384,
		// Token: 0x040001CE RID: 462
		[global::Cpp2ILInjected.Token(Token = "0x40001FB")]
		TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256,
		// Token: 0x040001CF RID: 463
		[global::Cpp2ILInjected.Token(Token = "0x40001FC")]
		TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384,
		// Token: 0x040001D0 RID: 464
		[global::Cpp2ILInjected.Token(Token = "0x40001FD")]
		TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256,
		// Token: 0x040001D1 RID: 465
		[global::Cpp2ILInjected.Token(Token = "0x40001FE")]
		TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384,
		// Token: 0x040001D2 RID: 466
		[global::Cpp2ILInjected.Token(Token = "0x40001FF")]
		TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256,
		// Token: 0x040001D3 RID: 467
		[global::Cpp2ILInjected.Token(Token = "0x4000200")]
		TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384,
		// Token: 0x040001D4 RID: 468
		[global::Cpp2ILInjected.Token(Token = "0x4000201")]
		TLS_RSA_WITH_AES_128_CCM,
		// Token: 0x040001D5 RID: 469
		[global::Cpp2ILInjected.Token(Token = "0x4000202")]
		TLS_RSA_WITH_AES_256_CCM,
		// Token: 0x040001D6 RID: 470
		[global::Cpp2ILInjected.Token(Token = "0x4000203")]
		TLS_DHE_RSA_WITH_AES_128_CCM,
		// Token: 0x040001D7 RID: 471
		[global::Cpp2ILInjected.Token(Token = "0x4000204")]
		TLS_DHE_RSA_WITH_AES_256_CCM,
		// Token: 0x040001D8 RID: 472
		[global::Cpp2ILInjected.Token(Token = "0x4000205")]
		TLS_RSA_WITH_AES_128_CCM_8,
		// Token: 0x040001D9 RID: 473
		[global::Cpp2ILInjected.Token(Token = "0x4000206")]
		TLS_RSA_WITH_AES_256_CCM_8,
		// Token: 0x040001DA RID: 474
		[global::Cpp2ILInjected.Token(Token = "0x4000207")]
		TLS_DHE_RSA_WITH_AES_128_CCM_8,
		// Token: 0x040001DB RID: 475
		[global::Cpp2ILInjected.Token(Token = "0x4000208")]
		TLS_DHE_RSA_WITH_AES_256_CCM_8,
		// Token: 0x040001DC RID: 476
		[global::Cpp2ILInjected.Token(Token = "0x4000209")]
		TLS_PSK_WITH_AES_128_CCM,
		// Token: 0x040001DD RID: 477
		[global::Cpp2ILInjected.Token(Token = "0x400020A")]
		TLS_PSK_WITH_AES_256_CCM,
		// Token: 0x040001DE RID: 478
		[global::Cpp2ILInjected.Token(Token = "0x400020B")]
		TLS_DHE_PSK_WITH_AES_128_CCM,
		// Token: 0x040001DF RID: 479
		[global::Cpp2ILInjected.Token(Token = "0x400020C")]
		TLS_DHE_PSK_WITH_AES_256_CCM,
		// Token: 0x040001E0 RID: 480
		[global::Cpp2ILInjected.Token(Token = "0x400020D")]
		TLS_PSK_WITH_AES_128_CCM_8,
		// Token: 0x040001E1 RID: 481
		[global::Cpp2ILInjected.Token(Token = "0x400020E")]
		TLS_PSK_WITH_AES_256_CCM_8,
		// Token: 0x040001E2 RID: 482
		[global::Cpp2ILInjected.Token(Token = "0x400020F")]
		TLS_PSK_DHE_WITH_AES_128_CCM_8,
		// Token: 0x040001E3 RID: 483
		[global::Cpp2ILInjected.Token(Token = "0x4000210")]
		TLS_PSK_DHE_WITH_AES_256_CCM_8,
		// Token: 0x040001E4 RID: 484
		[global::Cpp2ILInjected.Token(Token = "0x4000211")]
		TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52243,
		// Token: 0x040001E5 RID: 485
		[global::Cpp2ILInjected.Token(Token = "0x4000212")]
		TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256,
		// Token: 0x040001E6 RID: 486
		[global::Cpp2ILInjected.Token(Token = "0x4000213")]
		TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256,
		// Token: 0x040001E7 RID: 487
		[global::Cpp2ILInjected.Token(Token = "0x4000214")]
		TLS_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58384,
		// Token: 0x040001E8 RID: 488
		[global::Cpp2ILInjected.Token(Token = "0x4000215")]
		TLS_RSA_WITH_SALSA20_SHA1,
		// Token: 0x040001E9 RID: 489
		[global::Cpp2ILInjected.Token(Token = "0x4000216")]
		TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1,
		// Token: 0x040001EA RID: 490
		[global::Cpp2ILInjected.Token(Token = "0x4000217")]
		TLS_ECDHE_RSA_WITH_SALSA20_SHA1,
		// Token: 0x040001EB RID: 491
		[global::Cpp2ILInjected.Token(Token = "0x4000218")]
		TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1,
		// Token: 0x040001EC RID: 492
		[global::Cpp2ILInjected.Token(Token = "0x4000219")]
		TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1,
		// Token: 0x040001ED RID: 493
		[global::Cpp2ILInjected.Token(Token = "0x400021A")]
		TLS_PSK_WITH_ESTREAM_SALSA20_SHA1,
		// Token: 0x040001EE RID: 494
		[global::Cpp2ILInjected.Token(Token = "0x400021B")]
		TLS_PSK_WITH_SALSA20_SHA1,
		// Token: 0x040001EF RID: 495
		[global::Cpp2ILInjected.Token(Token = "0x400021C")]
		TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1,
		// Token: 0x040001F0 RID: 496
		[global::Cpp2ILInjected.Token(Token = "0x400021D")]
		TLS_ECDHE_PSK_WITH_SALSA20_SHA1,
		// Token: 0x040001F1 RID: 497
		[global::Cpp2ILInjected.Token(Token = "0x400021E")]
		TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1,
		// Token: 0x040001F2 RID: 498
		[global::Cpp2ILInjected.Token(Token = "0x400021F")]
		TLS_RSA_PSK_WITH_SALSA20_SHA1,
		// Token: 0x040001F3 RID: 499
		[global::Cpp2ILInjected.Token(Token = "0x4000220")]
		TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1,
		// Token: 0x040001F4 RID: 500
		[global::Cpp2ILInjected.Token(Token = "0x4000221")]
		TLS_DHE_PSK_WITH_SALSA20_SHA1,
		// Token: 0x040001F5 RID: 501
		[global::Cpp2ILInjected.Token(Token = "0x4000222")]
		TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1,
		// Token: 0x040001F6 RID: 502
		[global::Cpp2ILInjected.Token(Token = "0x4000223")]
		TLS_DHE_RSA_WITH_SALSA20_SHA1,
		// Token: 0x040001F7 RID: 503
		[global::Cpp2ILInjected.Token(Token = "0x4000224")]
		TLS_FALLBACK_SCSV = 22016
	}
}
