SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `tribeloot` BEFORE INSERT ON `movable_objects` FOR EACH ROW BEGIN
DECLARE _rnd int DEFAULT 0;

IF new.ObjectTypeID = (3001,3003,3005,3007,3009) THEN   
   
   Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
		VALUES (new.RootContainerID, 1060, 10, 100, 0, 0);

		set _rnd = FLOOR(RAND()*100);				  
		if _rnd > 90 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3010, 40, 1, 16000, 16000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 93 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3010, 60, 1, 160000, 160000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 96 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3010, 80, 1, 250000, 250000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 90 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3011, 40, 1, 16000, 16000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 93 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3011, 60, 1, 160000, 160000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 96 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3011, 80, 1, 250000, 250000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 90 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3012, 40, 1, 16000, 16000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);		  
		if _rnd > 93 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3012, 60, 1, 160000, 160000);
		END IF;
						
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 96 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 3012, 80, 1, 250000, 250000);
		END IF;
		
		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 79 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 658, 100, 1, 0, 0);
		END IF;			

		set _rnd = FLOOR(RAND()*100);	
		if _rnd > 94 then 
      	Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 1339, 100, 1, 16000, 16000);
		END IF;


END if;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;
