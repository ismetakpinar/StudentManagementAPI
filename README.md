# StudentManagementAPI

ASP.NET Core 8 kullanılarak geliştirilmiş öğrenci yönetim sistemi Web API projesi.

## Proje Özellikleri

- Öğrenci Ekleme
- Öğrenci Listeleme
- Öğrenci Güncelleme
- Öğrenci Silme
- DTO Kullanımı
- Repository Pattern
- AutoMapper Entegrasyonu
- FluentValidation ile Veri Doğrulama
- Global Exception Handling Middleware
- Entity Framework Core
- SQL Server Veritabanı

## Kullanılan Teknolojiler

- ASP.NET Core 8
- Entity Framework Core
- SQL Server
- Repository Pattern
- AutoMapper
- FluentValidation
- Swagger (OpenAPI)

## Endpointler

### Öğrenci İşlemleri

```http
GET /api/Students
```

Tüm öğrencileri listeler.

```http
GET /api/Students/{id}
```

Belirli bir öğrenciyi getirir.

```http
POST /api/Students
```

Yeni öğrenci oluşturur.

```http
PUT /api/Students/{id}
```

Öğrenci bilgilerini günceller.

```http
DELETE /api/Students/{id}
```

Öğrenciyi siler.

## Mimari Yapı

Proje aşağıdaki katmanlı mimari yaklaşımı kullanılarak geliştirilmiştir:

- Controller Katmanı
- Repository Katmanı
- Entity Katmanı
- DTO Katmanı
- Data Access Katmanı

## Veri Doğrulama

FluentValidation kullanılarak:

- Zorunlu alan kontrolleri
- Veri formatı kontrolleri
- İş kuralları doğrulamaları

uygulanmıştır.

## Hata Yönetimi

Global Exception Middleware kullanılarak:

- Merkezi hata yönetimi
- Standart hata cevapları
- Daha okunabilir API çıktıları

sağlanmıştır.

## Öğrenilen Konular

Bu proje kapsamında aşağıdaki konular uygulanmıştır:

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Repository Pattern
- Dependency Injection (DI)
- DTO (Data Transfer Object)
- AutoMapper
- FluentValidation
- Middleware
- Exception Handling
- CRUD Operasyonları

## Geliştirici

İsmet Akpınar
