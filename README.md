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
