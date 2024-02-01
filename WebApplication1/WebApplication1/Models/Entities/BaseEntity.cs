using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models.Entities
{
    public class BaseEntity
    {
        //
        // Summary:
        //     登録日時
        //[Comment("登録日時")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //
        // Summary:
        //     登録ユーザID
        [Column(TypeName = "varchar(32)")]
        //[Comment("登録ユーザID")]
        public string CreateUserId { get; set; } = "default user id";

        //
        // Summary:
        //     登録プログラムID
        [Column(TypeName = "varchar(32)")]
        //[Comment("登録プログラムID")]
        public string? CreateProgramId { get; set; }

        //
        // Summary:
        //     更新日時
        //[Column(TypeName = "datetime(6)")]
        //[Comment("更新日時")]
        public DateTime? UpdatedAt { get; set; }

        //
        // Summary:
        //     更新ユーザID
        [Column(TypeName = "varchar(32)")]
        //[Comment("更新ユーザーID")]
        public string? UpdateUserId { get; set; }

        //
        // Summary:
        //     登録プログラムID
        [Column(TypeName = "varchar(32)")]
        //[Comment("更新プログラムID")]
        public string? UpdateProgramId { get; set; }

        //
        // Summary:
        //     論理削除日時
        //[Comment("削除日時")]
        public DateTime DeletedAt { get; set; } = DateTime.MinValue;


        //
        // Summary:
        //     論理削除ユーザーID
        [Column(TypeName = "varchar(32)")]
        //[Comment("削除ユーザーID")]
        public string? DeleteUserId { get; set; }

        //
        // Summary:
        //     削除プログラムID
        [Column(TypeName = "varchar(32)")]
        //[Comment("削除プログラムID")]
        public string? DeleteProgramId { get; set; }

        //
        // Summary:
        //     代理ログイン操作更新日時
        //[Comment("代理ログイン操作更新日時")]
        public DateTime? AdminUpdatedAt { get; set; }

        //
        // Summary:
        //     代理ログインユーザーID
        [Column(TypeName = "varchar(255)")]
        //[Comment("代理ログインユーザーID")]
        public string? AdminUpdateUserId { get; set; }

        //
        // Summary:
        //     更新タイムスタンプ
        //[Comment("更新タイムスタンプ")]
        [Timestamp]
        [ConcurrencyCheck]
        public byte[] RowVersion { get; set; }
    }
}