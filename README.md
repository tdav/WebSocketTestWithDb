#   CREATE SERVICE

        nano /etc/systemd/system/ocpp.websocket.server.service
        
        systemctl status ocpp.mobile.app.redirection.service
        systemctl status ocpp.payment.service
        systemctl status ocpp.notification.service
        systemctl status ocpp.admin.service
        systemctl status ocpp.report.service
        systemctl status ocpp.ws16.service

        systemctl stop ocpp.mobile.app.redirection.service
        systemctl stop ocpp.payment.service
        systemctl stop ocpp.notification.service
        
        systemctl stop ocpp.admin.service
        systemctl stop ocpp.report.service
        systemctl stop ocpp.ws16.service


        systemctl start ocpp.mobile.app.redirection.service
        systemctl start ocpp.notification.service
        systemctl start ocpp.payment.service

        systemctl start ocpp.admin.service
        systemctl start ocpp.report.service
        systemctl start ocpp.ws16.service

#   Migration DB

        Add-Migration chAlert -Context MyDbContext
        Add-Migration chSysMes -Context MySysLogDbContext

#   REDIS

        https://github.com/tporadowski/redis/releases

#   Simulator
    
    wss://tranon-websockets.apps24.uz/OCPP/Test3333
    wss://localhost:8081/OCPP/Test3333

    https://github.com/DevExpress-Examples/aspnet-core-dashboard-jwt-authentication/blob/29d540dc99bd7cd593e716569c06805ca5ac5a2b/CS/Startup.cs#L47-L59



#   Remote commands

    https://developer.greenflux.com/docs/remote-commands

    Charge Station Commands:

        Start session
        Stop session
        Unlock Connector
        Reset

    Reservations

        ReserveNow
        CancelReservation

        INSERT INTO public.tb_charge_points (id,charge_point_id,"name",username,"password",client_cert_thumb,latitude,longitude,region_id,district_id,street,landmark,status,create_user,update_user,create_date,update_date) VALUES
	 (1,'22E05701','Test1234',NULL,NULL,NULL,41.284135,69.211267,10,1007,NULL,NULL,1,'501b4936-f418-45c9-87e8-03759527221f',NULL,'2023-09-29 17:37:49.393822',NULL),
	 (2,'Test3333','Test3333',NULL,NULL,NULL,41.313863,69.222854,10,1006,NULL,NULL,1,'501b4936-f418-45c9-87e8-03759527221f',NULL,'2023-09-29 17:37:49.393823',NULL),
	 (3,'Test9999','Test9999',NULL,'1',NULL,41.331731,69.301874,10,1002,NULL,NULL,1,'501b4936-f418-45c9-87e8-03759527221f',NULL,'2023-09-29 17:37:49.393824',NULL);


INSERT INTO public.tb_charge_tags (tag_id,tag_name,parent_tag_id,expiry_date,"blocked",status,create_user,update_user,create_date,update_date) VALUES
	 ('B4A63CDF','B4A63CDF',NULL,'2033-09-29 17:37:49.393825',false,1,'501b4936-f418-45c9-87e8-03759527221f',NULL,'2023-09-29 17:37:49.393828',NULL);

# Open port

    sudo firewall-cmd --permanent --add-port=51200/tcp   #SSH PORT

    sudo firewall-cmd --permanent --add-port=45200/tcp      
    sudo firewall-cmd --reload

    sudo firewall-cmd --list-ports

    Running programs
    sudo netstat -tulpn | grep LISTEN   

# Check port

    nc -zvw10 10.100.213.4 45000



#   PLANS

    ChargePoint 
	    Search
	    Start
	    Stop
	    SignalR - Stop булди

    QueueDrivers	
	    CRUD
	    SignalR - очеред келди
	
    Payments	
	    Create Ордер
	    SignalR - Payment success
	    GetBalance	
	
    User
	    Sms verify	



#   SQL

    CREATE OR REPLACE VIEW public.vi_connector_status_view
    AS SELECT cs.charge_point_id,
        cs.connector_id,
        cs.connector_name,
        cs.last_status,
        cs.last_status_time,
        cs.last_meter,
        cs.last_meter_time,
        t.id,
        t.start_tag_id,
        t.start_time,
        t.meter_start,
        t.start_result,
        t.stop_tag_id,
        t.stop_time,
        t.meter_stop,
        t.stop_reason
       FROM tb_connector_statuses cs
         LEFT JOIN tb_transactions t ON t.charge_point_id::text = cs.charge_point_id::text AND t.connector_id = cs.connector_id
      WHERE t.id IS NULL OR (t.id IN ( SELECT max(t_1.id) AS expr1
               FROM tb_transactions t_1
              GROUP BY t_1.charge_point_id, t_1.connector_id));

#   ASP.NET Core Minimal APIs
    https://anthonygiretti.com/2023/03/16/asp-net-core7-use-endpoint-groups-to-manage-minimal-apis-versioning/
    https://blog.jetbrains.com/dotnet/2023/04/25/introduction-to-asp-net-core-minimal-apis/


#   CREATE SERVICE
        nano /etc/systemd/system/ocpp_api.service
        systemctl enable ocpp_api.service
        systemctl start ocpp_api.service


        [Unit]
        Description=Ocpp Api Server

        [Service]
        WorkingDirectory=/var/www/tranon-api.apps24.uz
        ExecStart=/var/www/tranon-api.apps24.uz/ocpp.api.server --urls=http://localhost:10000/
        Restart=always

        RestartSec=10
        KillSignal=SIGINT
        SyslogIdentifier=ocpp.api.server

        User=root
        Environment=ASPNETCORE_ENVIRONMENT=Production
        Environment=DOTNET_PRINT_TELEMETRY_MESSAGE=false

        [Install]
        WantedBy=multi-user.target




        nano /etc/systemd/system/ocpp_report.service
        systemctl enable ocpp_report.service
        systemctl start ocpp_report.service


        [Unit]
        Description=Ocpp Report Server

        [Service]
        WorkingDirectory=/var/www/tranon-report.apps24.uz
        ExecStart=/var/www/tranon-report.apps24.uz/ocpp.reporting --urls=http://localhost:10001/
        Restart=always

        RestartSec=10
        KillSignal=SIGINT
        SyslogIdentifier=ocpp.reporting

        User=root
        Environment=ASPNETCORE_ENVIRONMENT=Production
        Environment=DOTNET_PRINT_TELEMETRY_MESSAGE=false

        [Install]
        WantedBy=multi-user.target



#   Nginx conf  
     
 
    upstream ocpp_api_server {
        server localhost:10000;
    }

	server {
		 server_name tranon-api.apps24.uz;
		
		 error_log /var/log/nginx/tranon-api.apps24.err.log;

		 location / {
			proxy_pass              http://ocpp_api_server;
			proxy_set_header        X-Real-IP $remote_addr;
			proxy_set_header        X-Forwarded-For $proxy_add_x_forwarded_for;
			proxy_set_header        X-Forwarded-Proto $scheme;
			proxy_set_header   	Host $host;
			
		proxy_set_header Upgrade $http_upgrade;
		proxy_set_header Connection    $connection_upgrade;
		proxy_cache off;
		proxy_http_version 1.1;
		proxy_buffering off;
		proxy_read_timeout 100s;
		 }   

		listen 443 ssl; # managed by Certbot
		ssl_certificate /etc/letsencrypt/live/tranon-api.apps24.uz/fullchain.pem; # managed by Certbot
		ssl_certificate_key /etc/letsencrypt/live/tranon-api.apps24.uz/privkey.pem; # managed by Certbot
		include /etc/letsencrypt/options-ssl-nginx.conf; # managed by Certbot
		ssl_dhparam /etc/letsencrypt/ssl-dhparams.pem; # managed by Certbot

	}
	
	  server {
		if ($host = tranon-api.apps24.uz) {
			return 301 https://$host$request_uri;
		} # managed by Certbot


		 server_name tranon-api.apps24.uz;
		 listen 80;
		return 404; # managed by Certbot
	}
 


 # PRIMER

    https://www.ampeco.com/guides/complete-ocpp-guide/
    https://www.gridx.ai/knowledge/ocpp
    https://github.com/c-jimenez/open-ocpp/tree/develop/examples

    ISO15118  Plug&Charge


#   SMS Gateway
    
    https://89.236.221.209:8443/swagger-ui.html
    emin
    123456
    
#   Use Office File API on Linux
    
    https://docs.devexpress.com/OfficeFileAPI/401441/dotnet-core-support/use-office-file-api-on-linux?v=22.2#prerequisites