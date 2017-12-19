package softuniBlog.config;

import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.authority.AuthorityUtils;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.util.StringUtils;
import softuniBlog.entity.User;

import java.util.ArrayList;
import java.util.Collection;

public class BlogUserDetails extends User implements UserDetails{

    @Override
    public boolean isAccountNonExpired() {return true;};
    @Override
    public boolean isAccountNonLocked(){return true;};
    @Override
    public boolean isCredentialsNonExpired(){return true;};
    @Override
    public boolean isEnabled(){return true;};


    //--- Fields containing Current User and his Role

    private ArrayList<String> roles;

    private User user;

    //---- Constructor for class User
    public BlogUserDetails(ArrayList<String> roles, User user) {
        super(user.getEmail(), user.getFullName(), user.getPassword());
        this.roles = roles;
        this.user = user;
    }

    @Override
    public Collection<? extends GrantedAuthority> getAuthorities(){
        String userRoles = StringUtils.collectionToCommaDelimitedString(this.roles);
        return AuthorityUtils.commaSeparatedStringToAuthorityList(userRoles);
    }

    //----- method which is returning our current user

    public User getUser(){
        return this.user;
    }

    public String getUsername(){
        return this.user.getEmail();
    }
}
