/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `tribeloot_beer` BEFORE INSERT ON `movable_objects` FOR EACH ROW BEGIN
DECLARE _rnd int DEFAULT 0;

IF new.ObjectTypeID =3001 THEN   
   
   Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
		VALUES (new.RootContainerID, 1060, 100, 10, 0, 0);

		set _rnd = FLOOR(RAND()*100);				  
		if _rnd > 90 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3010, 40, 1, 8000, 80000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 93 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3010, 60, 1, 12000, 120000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 96 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3010, 80, 1, 16000, 160000);
		END IF;

END if;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;


SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `tribeloot_Chieftain` BEFORE INSERT ON `movable_objects` FOR EACH ROW BEGIN
DECLARE _rnd int DEFAULT 0;

   IF new.ObjectTypeID =3003 THEN       
      Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 1060, 100, 10, 0, 0);

		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 90 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3011, 40, 1, 80000, 8000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 93 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3011, 60, 1, 120000, 12000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 96 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3011, 80, 1, 160000, 16000);
		END IF;				  

END IF; 
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;


SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `tribeloot_hunter` BEFORE INSERT ON `movable_objects` FOR EACH ROW BEGIN
DECLARE _rnd int DEFAULT 0;

   IF new.ObjectTypeID =3005 THEN     
		
      Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
			VALUES (new.RootContainerID, 1060, 100, 10, 0, 0);
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 90 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3012, 40, 1, 80000, 8000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 93 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3012, 60, 1, 120000, 12000);
		END IF;
						
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 96 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3012, 80, 1, 160000, 16000);
		END IF;

		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 90 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3013, 40, 1, 80000, 8000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 93 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3013, 60, 1, 120000, 12000);
		END IF;
						
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 96 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3013, 80, 1, 160000, 16000);
		END IF;
		
END IF;  
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;


SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `tribeloot_Mole` BEFORE INSERT ON `movable_objects` FOR EACH ROW BEGIN
DECLARE _rnd int DEFAULT 0;

   IF new.ObjectTypeID =3007 THEN  
	     
      Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 1060, 100, 10, 0, 0);

		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 90 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3014, 40, 1, 80000, 8000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 93 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3014, 60, 1, 120000, 12000);
		END IF;
						
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 96 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3014, 80, 1, 160000, 16000);
		END IF;

END IF; 
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;


SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `tribeloot_witch` BEFORE INSERT ON `movable_objects` FOR EACH ROW BEGIN

DECLARE _rnd int DEFAULT 0;

   IF new.ObjectTypeID =3009 THEN       
      Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 1060, 100, 10, 0, 0);

		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 90 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3015, 40, 1, 80000, 8000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 93 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3015, 60, 1, 120000, 12000);
		END IF;
						
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 96 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3015, 80, 1, 160000, 16000);
		END IF;	  
				  
END IF;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
