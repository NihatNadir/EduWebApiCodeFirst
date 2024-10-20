# EduWebApiCodeFirst ENG || TR

#### Course can have more than one enrollment, a student can enroll in more than one course, an instructor can create more than one course, and student and course IDs are defined as Foreign Keys in the enrollments. Using the CodeFirstApproach the project is completed.

- EntityFramework, migration, and SqlServer libraries were added.
- CourseEntity, EnrollmentEntity, InstructorEntity, and StudentEntity classes were created.
- Appropriate variables and DataAnnotations were defined for the classes.
- A context was created, inheriting from DbContext.
- Dependency Injection was performed by adding (DbContextOptions<Entity>options) : base(options) to EduWebApiContext.
- Inside the context, DbSet<Entity> TableName => Set<Entity>(); variables were defined.
- Using OnModelCreating, the IDs within the tables were linked with one-to-many relationships.
- Connection strings were defined with appsettings, and server information was completed.
- program.cs, data fetching and usage were set up, creating one-to-many relationships, excluding the API.
---
#### Bir kursa 1'den fazla kayıt yapılabilir, bir öğrenci 1'den fazla kayıt yapabilir, bir eğitmen 1'den fazla kurs oluşturabilir, kayıtlarda ise öğrenci ve kurs Id'leri ForeignKey olarak tanımlanmıştır. CodeFirst yaklaşımı kullanılarak tamamlandı.

- EntityFramework, migration ve SqlServer kütüphaneleri eklendi. 
- CourseEntity, EnrollmentEntity, InstructorEntity, StudentEntity classları oluşturuldu.
- Classlara uygun değişkenler ve DataAnnotation tanımlandı.
- Context oluşturuldu ve DbContext'ten miras alması sağlandı
- EduWebApiContext'e (DbContextOptions<Entity>options) : base(options) ile Dependency Injection işlemi yapıldı.
- Context içinde DbSet<Entity>TabloAdı => Set<Entity>(); değişkenleri tanımlandı.
- OnModelCreating ile tabloların içindeki Id'ler birbirine 1'e çok ilişki ile bağlandı.
- appsetting ile ConnectionStrings tanımlandı ve server bilgileri tamamlandı.
- program.cs ile bu verileri getir ve kullan işlemi ile Api hariç 1'e çok bağlantı oluşturuldu.

