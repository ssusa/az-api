using Microsoft.EntityFrameworkCore;

namespace az_api.Models;

/// <summary>
/// Entity Framework DbContext
/// </summary>
public class AzDbContext : DbContext
{
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="options">DbContext オプション</param>
    public AzDbContext(DbContextOptions<AzDbContext> options) : base(options)
    {
    }

    /// <summary>
    /// 部署テーブル
    /// </summary>
    public DbSet<t_busyo> t_busyos { get; set; }

    /// <summary>
    /// 社員テーブル
    /// </summary>
    public DbSet<t_syain> t_syains { get; set; }

    /// <summary>
    /// 所属テーブル
    /// </summary>
    public DbSet<t_syozoku> t_syozokus { get; set; }

    /// <summary>
    /// モデル作成時の設定
    /// </summary>
    /// <param name="modelBuilder">モデルビルダー</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // t_busyo テーブルの設定
        modelBuilder.Entity<t_busyo>(entity =>
        {
            entity.ToTable("t_busyo", "az");
            entity.HasKey(e => e.id);
            entity.Property(e => e.busyo_cd)
                .HasMaxLength(10)
                .IsRequired();
            entity.Property(e => e.busyo_name)
                .HasMaxLength(100)
                .IsRequired();
        });

        // t_syain テーブルの設定
        modelBuilder.Entity<t_syain>(entity =>
        {
            entity.ToTable("t_syain", "az");
            entity.HasKey(e => e.id);
            entity.Property(e => e.syain_cd)
                .HasMaxLength(10)
                .IsRequired();
            entity.Property(e => e.syain_name)
                .HasMaxLength(100)
                .IsRequired();
        });

        // t_syozoku テーブルの設定
        modelBuilder.Entity<t_syozoku>(entity =>
        {
            entity.ToTable("t_syozoku", "az");
            entity.HasKey(e => e.id);
            entity.Property(e => e.t_syain_id)
                .IsRequired();
            entity.Property(e => e.t_busyo_id)
                .IsRequired();
            entity.Property(e => e.start_date)
                .HasColumnType("date")
                .IsRequired();

            // t_syain への外部キー関係
            entity.HasOne(e => e.t_syain)
                .WithMany()
                .HasForeignKey(e => e.t_syain_id);

            // t_busyo への外部キー関係
            entity.HasOne(e => e.t_busyo)
                .WithMany()
                .HasForeignKey(e => e.t_busyo_id);
        });
    }
}
