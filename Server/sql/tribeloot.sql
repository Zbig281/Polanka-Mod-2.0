-- Change the 1061 to your ObjectTypeID and the 1 to your Quality at the values

-- Thanks to Nyuton for helping me with this Code

-- IF at the query come an Error click ok it works after.

DELIMITER $$

CREATE TRIGGER `tribeloot_before_update` BEFORE UPDATE ON `movable_objects` FOR EACH ROW BEGIN


   IF old.ObjectTypeID IN (3001,3003,3005,3007,3009) AND new.IsComplete = 1 THEN
   
       
       Insert INTO items (ContainerID, ObjectTypeID, Quality, Quantity, Durability, CreatedDurability)
				  VALUES (new.RootContainerID, 1061, 100, 1, 0, 0);
       
    END IF; 


END $$

DELIMITER;