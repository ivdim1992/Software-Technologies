package lognoziroh.entity;

import org.omg.CosNaming.NamingContextExtPackage.StringNameHelper;

import javax.persistence.*;

@Entity
@Table(name = "reports")
public class Report {
    private Integer Id;
    private String Status;
    private String Message;
    private String Origin;


    public Report(String status, String message, String origin) {
        Status = status;
        Message = message;
        Origin = origin;
    }

    public Report(){

    }


    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer getId() {
        return Id;
    }

    public void setId(Integer id) {
        Id = id;
    }
    @Column(nullable = false)
    public String getStatus() {
        return Status;
    }

    public void setStatus(String status) {
        Status = status;
    }
    @Column(nullable = false)
    public String getMessage() {
        return Message;
    }

    public void setMessage(String message) {
        Message = message;
    }
    @Column(nullable = false)
    public String getOrigin() {
        return Origin;
    }

    public void setOrigin(String origin) {
        Origin = origin;
    }
}
