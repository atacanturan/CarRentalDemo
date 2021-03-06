# Car Rental Project

1. Created project architecture
2. Added database files
    - Made update for easy optimizations
      - Added IEntityRepository interface
3. Added **Core** layer
    - Every common files created in **Core** layer.
      - IDto
      - IEntity
      - IEntityRepository
      - EfEntityRepositoryBase
4. Refactored codes.
    - Added Result class.
    - Added DataResult class.
    - Added Messages class field for sending constant messages.
5. Added rent a car situation.
    - New entity, **User**
    - New entity, **Customer**
    - New entity, **Rental**
6. Added WebAPI
    - This is connection layer between project area and localhost
7. Added Autofac
    - With autofac, I avoid of dependency in API layer.
8. Added AOP
    - Apply Fluent Validation to Controllers
9. Added image support
    - Adding car images
    - Updating car images
    - Deleting car images 

## **Database Designers**

### Car
![sql-car](https://user-images.githubusercontent.com/51711350/108781947-c5822500-757b-11eb-963b-f17dc4e4ab16.png)

### Brand
![sql-brand](https://user-images.githubusercontent.com/51711350/108781970-ce72f680-757b-11eb-8604-1bbbfb64fda4.png)

### Color
![sql-color](https://user-images.githubusercontent.com/51711350/108781972-cfa42380-757b-11eb-8e6d-e1c738c0c880.png)

### Rental
![sql-rental](https://user-images.githubusercontent.com/51711350/108781986-d5016e00-757b-11eb-918f-5cdc1e92e266.png)

### Customer
![sql-customer](https://user-images.githubusercontent.com/51711350/108782004-db8fe580-757b-11eb-9e4f-094b3b951551.png)

## User
![sql-user](https://user-images.githubusercontent.com/51711350/108781998-d894f500-757b-11eb-9e71-03720bd685ac.png)
