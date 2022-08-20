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

IF new.ObjectTypeID =2501 THEN   
   
   Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
		VALUES (new.RootContainerID, 1060, 20, 50, 0, 0);

		set _rnd = FLOOR(RAND()*100);				  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2011, 60, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2010, 60, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 84 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2156, 60, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 84 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2157, 60, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2214, 65, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2215, 65, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2009, 60, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2012, 60, 1, 0, 0);
		END IF;
						
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 426, 90, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 79 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3351, 100, 1, 0, 0);
		END IF;			

		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 94 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3177, 80, 1, 16000, 16000);
		END IF;


END if;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;


SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `tribeloot_Chieftain` BEFORE INSERT ON `movable_objects` FOR EACH ROW BEGIN
DECLARE _rnd int DEFAULT 0;

   IF new.ObjectTypeID =2503 THEN       
      Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 1060, 20, 100, 0, 0);	
				  
		set _rnd = FLOOR(RAND()*100);				  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2011, 60, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2010, 60, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 84 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2156, 60, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 84 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2157, 60, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2014, 100, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2013, 100, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2016, 100, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2017, 100, 1, 0, 0);
		END IF;
						
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2009, 60, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2012, 60, 1, 0, 0);
		END IF;			

		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 98 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3251, 80, 1, 16000, 16000);
		END IF;	


   END IF; 

END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;


SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `tribeloot_hunter` BEFORE INSERT ON `movable_objects` FOR EACH ROW BEGIN
DECLARE _rnd int DEFAULT 0;

   IF new.ObjectTypeID =2505 THEN     
		
      Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
			VALUES (new.RootContainerID, 1060, 20, 100, 0, 0);
				  
		set _rnd = FLOOR(RAND()*100);				  
		if _rnd > 84 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 657, 80, 5, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 84 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 656, 80, 5, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 84 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 344, 90, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 84 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 345, 90, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 79 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 668, 90, 9, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 429, 50, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 376, 90, 3, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3102, 90, 5, 0, 0);
		END IF;			
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3105, 60, 5, 0, 0);
		END IF;			
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3106, 60, 5, 0, 0);
		END IF;	
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 94 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3153, 100, 1, 20000, 20000);
		END IF;	
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 79 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2512, 70, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 79 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2513, 50, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 79 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3351, 100, 1, 12000, 12000);
		END IF;
		
		
		
    END IF; 
 
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;


SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `tribeloot_Mole` BEFORE INSERT ON `movable_objects` FOR EACH ROW BEGIN
DECLARE _rnd int DEFAULT 0;

   IF new.ObjectTypeID =2507 THEN  
	     
      Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 1060, 20, 100, 0, 0);

		set _rnd = FLOOR(RAND()*100);				  
		if _rnd > 79 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 328, 50, 25, 0, 0);
		END IF;
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 79 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 329, 50, 25, 0, 0);
		END IF;
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 330, 50, 15, 0, 0);
		END IF;
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 331, 50, 15, 0, 0);
		END IF;
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 84 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 486, 50, 1, 0, 0);
		END IF;
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 84 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 47, 50, 1, 12000, 12000);
		END IF;
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 84 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 48, 60, 1, 14400, 14400);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 79 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2514, 50, 1, 0, 0);
		END IF;			
		

    END IF; 

END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;


SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `tribeloot_witch` BEFORE INSERT ON `movable_objects` FOR EACH ROW BEGIN

DECLARE _rnd int DEFAULT 0;

   IF new.ObjectTypeID =2509 THEN       
      Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 1060, 20, 100, 0, 0);
	  
				  
		set _rnd = FLOOR(RAND()*100);				  
		if _rnd > 79 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 949, 80, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 79 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 781, 80, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 79 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 30, 60, 1, 11440, 11440);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 788, 80, 2, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 939, 80, 2, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 1699, 60, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3067, 50, 1, 0, 0);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2446, 50, 10, 0, 0);
		END IF;			
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 938, 80, 4, 0, 0);
		END IF;			
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 89 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 793, 80, 4, 0, 0);
		END IF;	
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 94 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 476, 80, 8, 0, 0);
		END IF;	
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 79 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 2515, 70, 1, 0, 0);
		END IF;


    END IF; 

END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
