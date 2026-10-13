using Microsoft.EntityFrameworkCore;
using SelfOrderSystem.Models;
using SelfOrderSystem.View_Models;

namespace SelfOrderSystem.Data {
    public class AppDbContext : DbContext {

        //Progaram.csで登録した接続設定を受け取る
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }   //受け取った設定を親クラスへ渡す

        //CategoryテーブルをCategory型として問い合わせるためのプロパティ
        public DbSet<Category> Categories => Set<Category>();

        //ProductテーブルをProduct型として問い合わせるためのプロパティ
        public DbSet<Product> Products => Set<Product>();
    }
}
