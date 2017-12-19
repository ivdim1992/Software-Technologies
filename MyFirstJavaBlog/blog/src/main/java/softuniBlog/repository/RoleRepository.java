package softuniBlog.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import softuniBlog.entity.Role;

//----- Repository for the Role
public interface RoleRepository extends JpaRepository<Role, Integer> {

    Role findByName(String name);
}
