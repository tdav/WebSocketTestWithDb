using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Database.Migrations
{
    /// <inheritdoc />
    public partial class t1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sp_car_brands",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<Guid>(type: "uuid", nullable: false),
                    update_user = table.Column<Guid>(type: "uuid", nullable: true),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    name_uz = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_lt = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_ru = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_en = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_car_brands", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_regions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<Guid>(type: "uuid", nullable: false),
                    update_user = table.Column<Guid>(type: "uuid", nullable: true),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "NOW()"),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    name_uz = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_lt = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_ru = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_en = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_regions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_statuses",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<Guid>(type: "uuid", nullable: false),
                    update_user = table.Column<Guid>(type: "uuid", nullable: true),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "NOW()"),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    name_uz = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_lt = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_ru = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_en = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_statuses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_units",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    short_name = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<Guid>(type: "uuid", nullable: false),
                    update_user = table.Column<Guid>(type: "uuid", nullable: true),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "NOW()"),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    name_uz = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_lt = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_ru = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_en = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_units", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sx_roles",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    normalized_name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    concurrency_stamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sx_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_alerts",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    priority = table.Column<int>(type: "integer", nullable: false),
                    charge_point_id = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    connector_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    json_data = table.Column<string>(type: "text", nullable: true),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_alerts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_image",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    file_name = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    size = table.Column<int>(type: "integer", nullable: false),
                    file_path = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<Guid>(type: "uuid", nullable: false),
                    update_user = table.Column<Guid>(type: "uuid", nullable: true),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "NOW()"),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_image", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_car_models",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    brand_id = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<Guid>(type: "uuid", nullable: false),
                    update_user = table.Column<Guid>(type: "uuid", nullable: true),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    name_uz = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_lt = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_ru = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_en = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_car_models", x => x.id);
                    table.ForeignKey(
                        name: "fk_sp_car_models_sp_car_brands_brand_id",
                        column: x => x.brand_id,
                        principalTable: "sp_car_brands",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sp_districts",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    region_id = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<Guid>(type: "uuid", nullable: false),
                    update_user = table.Column<Guid>(type: "uuid", nullable: true),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "NOW()"),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    name_uz = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_lt = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_ru = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    name_en = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_districts", x => x.id);
                    table.ForeignKey(
                        name: "fk_sp_districts_sp_regions_region_id",
                        column: x => x.region_id,
                        principalTable: "sp_regions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sx_role_claims",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_id = table.Column<Guid>(type: "uuid", nullable: false),
                    claim_type = table.Column<string>(type: "text", nullable: true),
                    claim_value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sx_role_claims", x => x.id);
                    table.ForeignKey(
                        name: "fk_sx_role_claims_sx_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "sx_roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sx_users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    surname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    patronymic = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    balance_summa = table.Column<double>(type: "double precision", nullable: false),
                    verified = table.Column<bool>(type: "boolean", nullable: false),
                    refresh_token = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    refresh_token_expiry_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<Guid>(type: "uuid", nullable: false),
                    update_user = table.Column<Guid>(type: "uuid", nullable: true),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "NOW()"),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    sp_role_id = table.Column<Guid>(type: "uuid", nullable: true),
                    user_name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    normalized_user_name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    normalized_email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    email_confirmed = table.Column<bool>(type: "boolean", nullable: false),
                    password_hash = table.Column<string>(type: "text", nullable: true),
                    security_stamp = table.Column<string>(type: "text", nullable: true),
                    concurrency_stamp = table.Column<string>(type: "text", nullable: true),
                    phone_number = table.Column<string>(type: "text", nullable: true),
                    phone_number_confirmed = table.Column<bool>(type: "boolean", nullable: false),
                    two_factor_enabled = table.Column<bool>(type: "boolean", nullable: false),
                    lockout_end = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    lockout_enabled = table.Column<bool>(type: "boolean", nullable: false),
                    access_failed_count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sx_users", x => x.id);
                    table.ForeignKey(
                        name: "fk_sx_users_asp_net_roles_sp_role_id",
                        column: x => x.sp_role_id,
                        principalTable: "sx_roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_cars",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    plate_number = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    vin_code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ev_battery_capacity = table.Column<int>(type: "integer", nullable: false),
                    charging_per_minute = table.Column<double>(type: "double precision", nullable: false),
                    brand_id = table.Column<int>(type: "integer", nullable: true),
                    model_id = table.Column<int>(type: "integer", nullable: true),
                    driver_id = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<Guid>(type: "uuid", nullable: false),
                    update_user = table.Column<Guid>(type: "uuid", nullable: true),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_cars", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_cars_sp_car_brands_brand_id",
                        column: x => x.brand_id,
                        principalTable: "sp_car_brands",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_tb_cars_sp_car_models_model_id",
                        column: x => x.model_id,
                        principalTable: "sp_car_models",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sx_user_claims",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    claim_type = table.Column<string>(type: "text", nullable: true),
                    claim_value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sx_user_claims", x => x.id);
                    table.ForeignKey(
                        name: "fk_sx_user_claims_sx_users_user_id",
                        column: x => x.user_id,
                        principalTable: "sx_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sx_user_logins",
                columns: table => new
                {
                    login_provider = table.Column<string>(type: "text", nullable: false),
                    provider_key = table.Column<string>(type: "text", nullable: false),
                    provider_display_name = table.Column<string>(type: "text", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sx_user_logins", x => new { x.login_provider, x.provider_key });
                    table.ForeignKey(
                        name: "fk_sx_user_logins_sx_users_user_id",
                        column: x => x.user_id,
                        principalTable: "sx_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sx_user_roles",
                columns: table => new
                {
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    role_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sx_user_roles", x => new { x.user_id, x.role_id });
                    table.ForeignKey(
                        name: "fk_sx_user_roles_sx_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "sx_roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_sx_user_roles_sx_users_user_id",
                        column: x => x.user_id,
                        principalTable: "sx_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sx_user_tokens",
                columns: table => new
                {
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    login_provider = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sx_user_tokens", x => new { x.user_id, x.login_provider, x.name });
                    table.ForeignKey(
                        name: "fk_sx_user_tokens_sx_users_user_id",
                        column: x => x.user_id,
                        principalTable: "sx_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_queue_drivers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    phone_number = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    plate_number = table.Column<string>(type: "text", nullable: true),
                    begin_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    end_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    user_info = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    comment = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    cancel_reason = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    create_user = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    connector_id = table.Column<int>(type: "integer", nullable: false),
                    car_id = table.Column<int>(type: "integer", nullable: false),
                    update_user = table.Column<Guid>(type: "uuid", nullable: true),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "NOW()"),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_queue_drivers", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_queue_drivers_tb_cars_car_id",
                        column: x => x.car_id,
                        principalTable: "tb_cars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "sp_car_brands",
                columns: new[] { "id", "create_date", "create_user", "name", "name_en", "name_lt", "name_ru", "name_uz", "status", "update_date", "update_user" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "BMV", null, null, null, null, 1, null, null },
                    { 2, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "MERS", null, null, null, null, 1, null, null },
                    { 3, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "GM", null, null, null, null, 1, null, null },
                    { 4, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "BYD", null, null, null, null, 1, null, null },
                    { 5, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "CHERY", null, null, null, null, 1, null, null },
                    { 6, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "LI", null, null, null, null, 1, null, null },
                    { 7, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "GAZ", null, null, null, null, 1, null, null },
                    { 8, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "LAMBO", null, null, null, null, 1, null, null },
                    { 9, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "RENO", null, null, null, null, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "sp_regions",
                columns: new[] { "id", "create_date", "create_user", "name_en", "name_lt", "name_ru", "name_uz", "status", "update_date", "update_user" },
                values: new object[,]
                {
                    { 10, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТОШКЕНТ ШАҲРИ", 1, null, null },
                    { 11, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТОШКЕНТ ВИЛОЯТИ", 1, null, null },
                    { 12, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "СИРДАРЁ ВИЛОЯТИ", 1, null, null },
                    { 13, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЖИЗЗАХ ВИЛОЯТИ", 1, null, null },
                    { 14, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "САМАРҚАНД ВИЛОЯТИ", 1, null, null },
                    { 15, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ФАРҒОНА ВИЛОЯТИ", 1, null, null },
                    { 16, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НАМАНГАН ВИЛОЯТИ", 1, null, null },
                    { 17, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "АНДИЖОН ВИЛОЯТИ", 1, null, null },
                    { 18, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚАШҚАДАРЁ ВИЛОЯТИ", 1, null, null },
                    { 19, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "СУРХОНДАРЁ ВИЛОЯТИ", 1, null, null },
                    { 20, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БУХОРО ВИЛОЯТИ", 1, null, null },
                    { 21, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НАВОИЙ ВИЛОЯТИ", 1, null, null },
                    { 22, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ХОРАЗМ ВИЛОЯТИ", 1, null, null },
                    { 23, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚОРАҚАЛПОҒИСТОН РЕСПУБЛИКАСИ", 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "sp_statuses",
                columns: new[] { "id", "create_date", "create_user", "name_en", "name_lt", "name_ru", "name_uz", "status", "update_date", "update_user" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, "Amalda", "Активный", "Амалда", 1, null, null },
                    { 2, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, "Arhiv", "Архив", "Архив", 1, null, null },
                    { 5, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, "Vaqtincha o'chirilgan", "Временно отключен", "Вақтинча ўчирилган", 1, null, null },
                    { 6, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, "Ishlamaydi", "Не работает", "Ишламайди", 1, null, null },
                    { 9, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, "O`chrilgan", "Удалено", "Ўчирилган", 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "sp_car_models",
                columns: new[] { "id", "brand_id", "create_date", "create_user", "name", "name_en", "name_lt", "name_ru", "name_uz", "status", "update_date", "update_user" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "SPARK", null, null, null, null, 1, null, null },
                    { 2, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "3-SERIES", null, null, null, null, 1, null, null },
                    { 3, 4, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "TANG", null, null, null, null, 1, null, null },
                    { 4, 2, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "E-CLASS", null, null, null, null, 1, null, null },
                    { 5, 5, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "QQ", null, null, null, null, 1, null, null },
                    { 6, 6, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "XIAO", null, null, null, null, 1, null, null },
                    { 7, 7, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "GAZELLE", null, null, null, null, 1, null, null },
                    { 8, 8, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "HURACAN", null, null, null, null, 1, null, null },
                    { 9, 9, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "LOGAN", null, null, null, null, 1, null, null },
                    { 10, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "X5", null, null, null, null, 1, null, null },
                    { 11, 3, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "AVEO", null, null, null, null, 1, null, null },
                    { 12, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "5-SERIES", null, null, null, null, 1, null, null },
                    { 13, 4, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "ENCORE", null, null, null, null, 1, null, null },
                    { 14, 2, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "S-CLASS", null, null, null, null, 1, null, null },
                    { 15, 5, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "TIGGO", null, null, null, null, 1, null, null },
                    { 16, 6, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "XING", null, null, null, null, 1, null, null },
                    { 17, 7, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "SOBOL", null, null, null, null, 1, null, null },
                    { 18, 8, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "GALLARDO", null, null, null, null, 1, null, null },
                    { 19, 9, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "SANDERO", null, null, null, null, 1, null, null },
                    { 20, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "X7", null, null, null, null, 1, null, null },
                    { 21, 3, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "MALIBU", null, null, null, null, 1, null, null },
                    { 22, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "7-SERIES", null, null, null, null, 1, null, null },
                    { 23, 4, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "REGAL", null, null, null, null, 1, null, null },
                    { 24, 2, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "GLC", null, null, null, null, 1, null, null },
                    { 25, 5, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "ARRIZO", null, null, null, null, 1, null, null },
                    { 26, 6, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "E6", null, null, null, null, 1, null, null },
                    { 27, 7, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "TIGR", null, null, null, null, 1, null, null },
                    { 28, 8, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "URUS", null, null, null, null, 1, null, null },
                    { 29, 9, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "DUSTER", null, null, null, null, 1, null, null },
                    { 30, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "X1", null, null, null, null, 1, null, null },
                    { 31, 3, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "CRUZE", null, null, null, null, 1, null, null },
                    { 32, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "X6", null, null, null, null, 1, null, null },
                    { 33, 4, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "ENVISION", null, null, null, null, 1, null, null },
                    { 34, 2, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "GLE", null, null, null, null, 1, null, null },
                    { 35, 5, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "QQ3", null, null, null, null, 1, null, null },
                    { 36, 6, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "XUAN", null, null, null, null, 1, null, null },
                    { 37, 7, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "VOLGA", null, null, null, null, 1, null, null },
                    { 38, 8, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "ASTERION", null, null, null, null, 1, null, null },
                    { 39, 9, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "KAPTUR", null, null, null, null, 1, null, null },
                    { 40, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "X3", null, null, null, null, 1, null, null },
                    { 41, 3, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "AVEO", null, null, null, null, 1, null, null },
                    { 42, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "X4", null, null, null, null, 1, null, null },
                    { 43, 4, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "VERANO", null, null, null, null, 1, null, null },
                    { 44, 2, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "GLA", null, null, null, null, 1, null, null },
                    { 45, 5, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "QQ6", null, null, null, null, 1, null, null },
                    { 46, 6, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "XUE", null, null, null, null, 1, null, null },
                    { 47, 7, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "NEXT", null, null, null, null, 1, null, null },
                    { 48, 8, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "HURACAN EVO", null, null, null, null, 1, null, null },
                    { 49, 9, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "LATITUDE", null, null, null, null, 1, null, null },
                    { 50, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "X2", null, null, null, null, 1, null, null },
                    { 51, 3, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "SPARK", null, null, null, null, 1, null, null },
                    { 52, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "I3", null, null, null, null, 1, null, null },
                    { 53, 4, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "LACROSSE", null, null, null, null, 1, null, null },
                    { 54, 2, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "GLB", null, null, null, null, 1, null, null },
                    { 55, 5, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "TIGGO 2", null, null, null, null, 1, null, null },
                    { 56, 6, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "XIAO", null, null, null, null, 1, null, null },
                    { 57, 7, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "3110", null, null, null, null, 1, null, null },
                    { 58, 8, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "ASTERION LPI 910-4", null, null, null, null, 1, null, null },
                    { 59, 9, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "MEGANE", null, null, null, null, 1, null, null },
                    { 60, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "I8", null, null, null, null, 1, null, null },
                    { 61, 3, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "MALIBU", null, null, null, null, 1, null, null },
                    { 62, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "I4", null, null, null, null, 1, null, null },
                    { 63, 4, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "EXCELLE", null, null, null, null, 1, null, null },
                    { 64, 2, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "GLS", null, null, null, null, 1, null, null },
                    { 65, 5, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "TIGGO 3", null, null, null, null, 1, null, null },
                    { 66, 6, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "XIAO", null, null, null, null, 1, null, null },
                    { 67, 7, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "2752", null, null, null, null, 1, null, null },
                    { 68, 8, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "CENTENARIO", null, null, null, null, 1, null, null },
                    { 69, 9, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "KOLEOS", null, null, null, null, 1, null, null },
                    { 70, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "I9", null, null, null, null, 1, null, null },
                    { 71, 3, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "CRUZE", null, null, null, null, 1, null, null },
                    { 72, 1, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "I5", null, null, null, null, 1, null, null },
                    { 73, 4, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "ROYAUM", null, null, null, null, 1, null, null },
                    { 74, 2, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "CLA", null, null, null, null, 1, null, null },
                    { 75, 5, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "ARRIZO 5", null, null, null, null, 1, null, null },
                    { 76, 6, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), "XIAO", null, null, null, null, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "sp_districts",
                columns: new[] { "id", "create_date", "create_user", "name_en", "name_lt", "name_ru", "name_uz", "region_id", "status", "update_date", "update_user" },
                values: new object[,]
                {
                    { 1001, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "УЧТЕПА ТУМАНИ", 10, 1, null, null },
                    { 1002, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "СОБИР РАХИМОВ ТУМАНИ", 10, 1, null, null },
                    { 1003, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "МИРЗО УЛУҒБЕК ТУМАНИ", 10, 1, null, null },
                    { 1005, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЯККАСАРОЙ ТУМАНИ", 10, 1, null, null },
                    { 1006, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ШАЙХОНТОХУР ТУМАНИ", 10, 1, null, null },
                    { 1007, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЧИЛОНЗОР ТУМАНИ", 10, 1, null, null },
                    { 1008, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "СИРҒАЛИ ТУМАНИ", 10, 1, null, null },
                    { 1009, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "МИРОБОД ТУМАНИ", 10, 1, null, null },
                    { 1010, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЮНУСОБОД ТУМАНИ", 10, 1, null, null },
                    { 1011, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БЕКТЕМИР ТУМАНИ", 10, 1, null, null },
                    { 1012, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ОЛМАЗОР ТУМАНИ", 10, 1, null, null },
                    { 1101, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЯНГИЙЎЛ ТУМАНИ", 11, 1, null, null },
                    { 1102, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЗАНГИОТА ТУМАНИ", 11, 1, null, null },
                    { 1103, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ПИСКЕНТ ТУМАНИ", 11, 1, null, null },
                    { 1104, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ПАРКЕНТ ТУМАНИ", 11, 1, null, null },
                    { 1105, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЎРТАЧИРЧИҚ ТУМАНИ", 11, 1, null, null },
                    { 1106, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ОҚҚЎРҒОН ТУМАНИ", 11, 1, null, null },
                    { 1107, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚУЙИЧИРЧИҚ ТУМАНИ", 11, 1, null, null },
                    { 1108, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚИБРАЙ ТУМАНИ", 11, 1, null, null },
                    { 1109, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТОШКЕНТ ТУМАНИ", 11, 1, null, null },
                    { 1110, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ОХАНГАРОН ТУМАНИ", 11, 1, null, null },
                    { 1111, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БЕКОБОД ТУМАНИ", 11, 1, null, null },
                    { 1112, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БЎСТОНЛИҚ ТУМАНИ", 11, 1, null, null },
                    { 1113, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БЎКА ТУМАНИ", 11, 1, null, null },
                    { 1114, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЮҚОРИЧИРЧИҚ ТУМАНИ", 11, 1, null, null },
                    { 1115, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЧИНОЗ ТУМАНИ", 11, 1, null, null },
                    { 1116, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "АНГРЕН ШАҲРИ", 11, 1, null, null },
                    { 1117, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БЕКОБОД ШАҲРИ", 11, 1, null, null },
                    { 1118, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ОЛМАЛИК ШАҲРИ", 11, 1, null, null },
                    { 1119, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ОХАНГОРОН ШАҲРИ", 11, 1, null, null },
                    { 1120, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЧИРЧИҚ ШАҲРИ", 11, 1, null, null },
                    { 1121, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЯНГИОБОД ШАҲРИ", 11, 1, null, null },
                    { 1122, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЯНГИЙЎЛ ШАҲРИ", 11, 1, null, null },
                    { 1201, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "САЙХУНОБОД ТУМАНИ", 12, 1, null, null },
                    { 1202, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ГУЛИСТОН ТУМАНИ", 12, 1, null, null },
                    { 1203, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БОЁВУТ ТУМАНИ", 12, 1, null, null },
                    { 1204, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "МЕХНАТОБОД ТУМАНИ", 12, 1, null, null },
                    { 1205, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ХОВОС ТУМАНИ", 12, 1, null, null },
                    { 1206, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "МИРЗАОБОД ТУМАНИ", 12, 1, null, null },
                    { 1207, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ОҚОЛТИН ТУМАНИ", 12, 1, null, null },
                    { 1209, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "СИРДАРЁ ТУМАНИ", 12, 1, null, null },
                    { 1210, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ГУЛИСТОН ШАҲРИ", 12, 1, null, null },
                    { 1211, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "СИРДАРЁ ШАҲРИ", 12, 1, null, null },
                    { 1212, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ШИРИН ШАҲРИ", 12, 1, null, null },
                    { 1213, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЯНГИЕР ШАҲРИ", 12, 1, null, null },
                    { 1214, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БАХТ ШАҲРИ", 12, 1, null, null },
                    { 1215, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "САРДОБА ТУМАНИ", 12, 1, null, null },
                    { 1301, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЗАРБДОР ТУМАНИ", 13, 1, null, null },
                    { 1302, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ДЎСТЛИК ТУМАНИ", 13, 1, null, null },
                    { 1304, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ФОРИШ ТУМАНИ", 13, 1, null, null },
                    { 1305, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЖИЗЗАХ ТУМАНИ", 13, 1, null, null },
                    { 1306, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҒАЛЛАОРОЛ ТУМАНИ", 13, 1, null, null },
                    { 1307, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БАХМАЛ ТУМАНИ", 13, 1, null, null },
                    { 1308, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ПАХТАКОР ТУМАНИ", 13, 1, null, null },
                    { 1309, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЗАФАРОБОД ТУМАНИ", 13, 1, null, null },
                    { 1310, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "АРНАСОЙ ТУМАНИ", 13, 1, null, null },
                    { 1311, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЗОМИН ТУМАНИ", 13, 1, null, null },
                    { 1312, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "МИРЗАЧЎЛ ТУМАНИ", 13, 1, null, null },
                    { 1313, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЯНГИОБОД ТУМАНИ", 13, 1, null, null },
                    { 1314, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЖИЗЗАХ ШАҲРИ", 13, 1, null, null },
                    { 1401, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НАРПАЙ ТУМАНИ", 14, 1, null, null },
                    { 1402, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НУРОБОД ТУМАНИ", 14, 1, null, null },
                    { 1403, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЖОМБОЙ ТУМАНИ", 14, 1, null, null },
                    { 1404, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "УРГУТ ТУМАНИ", 14, 1, null, null },
                    { 1405, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ПАХТАЧИ ТУМАНИ", 14, 1, null, null },
                    { 1406, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КАТТАҚЎРҒОН ТУМАНИ", 14, 1, null, null },
                    { 1407, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ОҚДАРЁ ТУМАНИ", 14, 1, null, null },
                    { 1408, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ИШТИХОН ТУМАНИ", 14, 1, null, null },
                    { 1409, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ПАСТДАРҒОМ ТУМАНИ", 14, 1, null, null },
                    { 1410, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТАЙЛОҚ ТУМАНИ", 14, 1, null, null },
                    { 1411, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БУЛУНҒУР ТУМАНИ", 14, 1, null, null },
                    { 1412, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ГЎЗАЛКЕНТ ТУМАНИ", 14, 1, null, null },
                    { 1413, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "САМАРҚАНД ТУМАНИ", 14, 1, null, null },
                    { 1414, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚЎШРАБОД ТУМАНИ", 14, 1, null, null },
                    { 1415, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ПАЙАРИҚ ТУМАНИ", 14, 1, null, null },
                    { 1416, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЧЕЛАК ТУМАНИ", 14, 1, null, null },
                    { 1417, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "САМАРҚАНД ШАҲРИ", 14, 1, null, null },
                    { 1418, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БОҒИШАМОЛ ТУМАНИ", 14, 1, null, null },
                    { 1419, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТЕМИРЙЎЛ ТУМАНИ", 14, 1, null, null },
                    { 1420, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ОҚТОШ ШАҲРИ", 14, 1, null, null },
                    { 1421, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КАТТАҚЎРҒОН ШАҲРИ", 14, 1, null, null },
                    { 1422, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "УРГУТ ШАҲРИ", 14, 1, null, null },
                    { 1423, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "СИЁБ ТУМАНИ", 14, 1, null, null },
                    { 1501, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КИРГУЛИ ТУМАНИ", 15, 1, null, null },
                    { 1502, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ФАРҒОНА ТУМАНИ", 15, 1, null, null },
                    { 1503, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚУВА ТУМАНИ", 15, 1, null, null },
                    { 1504, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТОШЛОҚ ТУМАНИ", 15, 1, null, null },
                    { 1505, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ОХУНБОБОЕВ ТУМАНИ", 15, 1, null, null },
                    { 1506, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЁЗЁВОН ТУМАНИ", 15, 1, null, null },
                    { 1507, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ОЛТИАРИҚ ТУМАНИ", 15, 1, null, null },
                    { 1508, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БОҒДОД ТУМАНИ", 15, 1, null, null },
                    { 1509, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БУВАЙДА ТУМАНИ", 15, 1, null, null },
                    { 1510, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "УЧКЎПРИК ТУМАНИ", 15, 1, null, null },
                    { 1511, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "РИШТОН ТУМАНИ", 15, 1, null, null },
                    { 1512, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ДАНҒАРА ТУМАНИ", 15, 1, null, null },
                    { 1513, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ФУРҚАТ ТУМАНИ", 15, 1, null, null },
                    { 1514, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЎЗБЕКИСТОН ТУМАНИ", 15, 1, null, null },
                    { 1515, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БЕШАРИҚ ТУМАНИ", 15, 1, null, null },
                    { 1516, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "СЎХ ТУМАНИ", 15, 1, null, null },
                    { 1517, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚУВАСОЙ ШАҲРИ", 15, 1, null, null },
                    { 1518, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚУВА ШАҲРИ", 15, 1, null, null },
                    { 1519, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚЎҚОН ШАҲРИ", 15, 1, null, null },
                    { 1520, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "МАРҒИЛОН ШАҲРИ", 15, 1, null, null },
                    { 1521, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ФАРҒОНА ШАҲРИ", 15, 1, null, null },
                    { 1522, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КИРГУЛИ ШАҲРИ", 15, 1, null, null },
                    { 1601, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ДАВЛАТОБОД ТУМАНИ", 16, 1, null, null },
                    { 1602, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "МИНГБУЛОҚ ТУМАНИ", 16, 1, null, null },
                    { 1603, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НАМАНГАН ТУМАНИ", 16, 1, null, null },
                    { 1604, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НОРИН ТУМАНИ", 16, 1, null, null },
                    { 1605, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "УЙЧИ ТУМАНИ", 16, 1, null, null },
                    { 1606, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "УЧҚЎРҒОН ТУМАНИ", 16, 1, null, null },
                    { 1607, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЧОРТОҚ ТУМАНИ", 16, 1, null, null },
                    { 1608, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЯНГИҚЎРҒОН ТУМАНИ", 16, 1, null, null },
                    { 1609, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КОСОНСОЙ ТУМАНИ", 16, 1, null, null },
                    { 1610, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЧУСТ ТУМАНИ", 16, 1, null, null },
                    { 1611, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ПОП ТУМАНИ", 16, 1, null, null },
                    { 1612, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТЎРАҚЎРҒОН ТУМАНИ", 16, 1, null, null },
                    { 1613, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НАМАНГАН ШАҲРИ", 16, 1, null, null },
                    { 1614, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КОСОНСОЙ ШАҲРИ", 16, 1, null, null },
                    { 1615, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "УЧҚЎРҒОН ШАҲРИ", 16, 1, null, null },
                    { 1616, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЧОРТОҚ ШАҲРИ", 16, 1, null, null },
                    { 1617, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЧУСТ ШАҲРИ", 16, 1, null, null },
                    { 1618, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ХАҚҚУЛОБОД ШАҲРИ", 16, 1, null, null },
                    { 1701, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "АНДИЖОН ТУМАНИ", 17, 1, null, null },
                    { 1702, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ОЛТИНКЎЛ ТУМАНИ", 17, 1, null, null },
                    { 1703, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "АСАКА ТУМАНИ", 17, 1, null, null },
                    { 1704, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БАЛИҚЧИ ТУМАНИ", 17, 1, null, null },
                    { 1705, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БЎЗ ТУМАНИ", 17, 1, null, null },
                    { 1706, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "УЛУҒНОР ТУМАНИ", 17, 1, null, null },
                    { 1707, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ШАХРИХОН ТУМАНИ", 17, 1, null, null },
                    { 1708, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚЎРҒОНТЕПА ТУМАНИ", 17, 1, null, null },
                    { 1709, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЖАЛАҚУДУҚ ТУМАНИ", 17, 1, null, null },
                    { 1710, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ХЎЖАОБОД ТУМАНИ", 17, 1, null, null },
                    { 1711, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "МАРХАМАТ ТУМАНИ", 17, 1, null, null },
                    { 1712, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ИЗБОСКАН ТУМАНИ", 17, 1, null, null },
                    { 1713, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БУЛОҚБОШИ ТУМАНИ", 17, 1, null, null },
                    { 1714, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ПАХТАОБОД ТУМАНИ", 17, 1, null, null },
                    { 1715, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "АНДИЖОН ШАҲРИ", 17, 1, null, null },
                    { 1716, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "АСАКА ШАҲРИ", 17, 1, null, null },
                    { 1717, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ХОНОБОД ШАҲРИ", 17, 1, null, null },
                    { 1718, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ШАҲРИХОН ШАҲРИ", 17, 1, null, null },
                    { 1719, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚОРАСУВ ШАҲРИ", 17, 1, null, null },
                    { 1801, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЧИРОҚЧИ ТУМАНИ", 18, 1, null, null },
                    { 1802, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КОСОН ТУМАНИ", 18, 1, null, null },
                    { 1803, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ШАҲРИСАБЗ ТУМАНИ", 18, 1, null, null },
                    { 1804, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ДЕҲҚОНОБОД ТУМАНИ", 18, 1, null, null },
                    { 1805, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚАМАШИ ТУМАНИ", 18, 1, null, null },
                    { 1806, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЯККАБОҒ ТУМАНИ", 18, 1, null, null },
                    { 1807, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БАХОРИСТОН ТУМАНИ", 18, 1, null, null },
                    { 1808, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҒУЗОР ТУМАНИ", 18, 1, null, null },
                    { 1809, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚАРШИ ТУМАНИ", 18, 1, null, null },
                    { 1810, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НИШОН ТУМАНИ", 18, 1, null, null },
                    { 1811, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КИТОБ ТУМАНИ", 18, 1, null, null },
                    { 1812, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КАСБИ ТУМАНИ", 18, 1, null, null },
                    { 1813, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "МУБОРАК ТУМАНИ", 18, 1, null, null },
                    { 1814, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "МИРИШКОР ТУМАНИ", 18, 1, null, null },
                    { 1815, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚАРШИ ШАҲРИ", 18, 1, null, null },
                    { 1816, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ШАҲРИСАБЗ ШАҲРИ", 18, 1, null, null },
                    { 1901, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТЕРМИЗ ТУМАНИ", 19, 1, null, null },
                    { 1902, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БОЙСУН ТУМАНИ", 19, 1, null, null },
                    { 1903, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "МУЗРАБОТ ТУМАНИ", 19, 1, null, null },
                    { 1904, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "САРИОСИЁ ТУМАНИ", 19, 1, null, null },
                    { 1905, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ШАРҒУН ТУМАНИ", 19, 1, null, null },
                    { 1906, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ШЎРЧИ ТУМАНИ", 19, 1, null, null },
                    { 1907, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ОЛТИНСОЙ ТУМАНИ", 19, 1, null, null },
                    { 1908, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚУМҚЎРҒОН ТУМАНИ", 19, 1, null, null },
                    { 1909, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЖАРҚЎРҒОН ТУМАНИ", 19, 1, null, null },
                    { 1910, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚИЗИРИҚ ТУМАНИ", 19, 1, null, null },
                    { 1911, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "АНГОР ТУМАНИ", 19, 1, null, null },
                    { 1912, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ШЕРОБОД ТУМАНИ", 19, 1, null, null },
                    { 1913, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "УЗУН ТУМАНИ", 19, 1, null, null },
                    { 1914, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ДЕНОВ ТУМАНИ", 19, 1, null, null },
                    { 1915, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БАНДИХОН ТУМАНИ", 19, 1, null, null },
                    { 1916, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТЕРМИЗ ШАҲРИ", 19, 1, null, null },
                    { 1917, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ДЕНОВ ШАҲРИ", 19, 1, null, null },
                    { 2001, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "РОМИТАН ТУМАНИ", 20, 1, null, null },
                    { 2002, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ВОБКЕНТ ТУМАНИ", 20, 1, null, null },
                    { 2003, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ПЕШКУ ТУМАНИ", 20, 1, null, null },
                    { 2004, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ОЛОТ ТУМАНИ", 20, 1, null, null },
                    { 2005, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЖОНДОР ТУМАНИ", 20, 1, null, null },
                    { 2006, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚОРАКЎЛ ТУМАНИ", 20, 1, null, null },
                    { 2007, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ШОФИРКОН ТУМАНИ", 20, 1, null, null },
                    { 2008, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚОРОВУЛБОЗОР ТУМАНИ", 20, 1, null, null },
                    { 2009, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ГАЗЛИ ШАҲРИ", 20, 1, null, null },
                    { 2010, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БУХОРО ТУМАНИ", 20, 1, null, null },
                    { 2011, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КОГОН ТУМАНИ", 20, 1, null, null },
                    { 2012, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҒИЖДУВОН ТУМАНИ", 20, 1, null, null },
                    { 2013, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БУХОРО ШАҲРИ", 20, 1, null, null },
                    { 2014, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҒИЖДУВОН ШАҲРИ", 20, 1, null, null },
                    { 2015, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КОГОН ШАҲРИ", 20, 1, null, null },
                    { 2016, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "Ф.ХЎЖАЕВ ТУМАНИ", 20, 1, null, null },
                    { 2017, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТЎҚИМАЧИ ТУМАНИ", 20, 1, null, null },
                    { 2101, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "УЧҚУДУҚ ТУМАНИ", 21, 1, null, null },
                    { 2102, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КОНИМЕХ ТУМАНИ", 21, 1, null, null },
                    { 2104, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТОМДИ ТУМАНИ", 21, 1, null, null },
                    { 2105, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НАВБАҲОР ТУМАНИ", 21, 1, null, null },
                    { 2106, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НАВОИЙ ТУМАНИ", 21, 1, null, null },
                    { 2107, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НУРОТА ТУМАНИ", 21, 1, null, null },
                    { 2108, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ХАТИРЧИ ТУМАНИ", 21, 1, null, null },
                    { 2109, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚИЗИЛТЕПА ТУМАНИ", 21, 1, null, null },
                    { 2110, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КАРМАНА ТУМАНИ", 21, 1, null, null },
                    { 2111, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НАВОИЙ ШАҲРИ", 21, 1, null, null },
                    { 2112, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЗАРАФШОН ШАҲРИ", 21, 1, null, null },
                    { 2113, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "УЧҚУДУҚ ШАҲРИ", 21, 1, null, null },
                    { 2201, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ХАЗОРАСП ТУМАНИ", 22, 1, null, null },
                    { 2202, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЯНГИАРИҚ ТУМАНИ", 22, 1, null, null },
                    { 2203, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ГУРЛАН ТУМАНИ", 22, 1, null, null },
                    { 2204, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "УРГАНЧ ТУМАНИ", 22, 1, null, null },
                    { 2205, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ШОВОТ ТУМАНИ", 22, 1, null, null },
                    { 2206, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ХОНҚА ТУМАНИ", 22, 1, null, null },
                    { 2207, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БОҒОТ ТУМАНИ", 22, 1, null, null },
                    { 2208, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЯНГИБОЗОР ТУМАНИ", 22, 1, null, null },
                    { 2209, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚЎШКЎПИР ТУМАНИ", 22, 1, null, null },
                    { 2210, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ХИВА ТУМАНИ", 22, 1, null, null },
                    { 2211, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "УРГАНЧ ШАҲРИ", 22, 1, null, null },
                    { 2212, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ХИВА ШАҲРИ", 22, 1, null, null },
                    { 2213, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ПИТНАК ШАҲРИ", 22, 1, null, null },
                    { 2301, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НУКУС ТУМАНИ", 23, 1, null, null },
                    { 2302, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КУНГИРОТ ТУМАНИ", 23, 1, null, null },
                    { 2303, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "МЎЙНОҚ ТУМАНИ", 23, 1, null, null },
                    { 2305, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТЎРТКЎЛ ТУМАНИ", 23, 1, null, null },
                    { 2306, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЭЛЛИКҚАЛЪА ТУМАНИ", 23, 1, null, null },
                    { 2307, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КЕГЕЙЛИ ТУМАНИ", 23, 1, null, null },
                    { 2308, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "АМУДАРЁ ТУМАНИ", 23, 1, null, null },
                    { 2309, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БЕРУНИЙ ТУМАНИ", 23, 1, null, null },
                    { 2310, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КАНЛИКОЛ ТУМАНИ", 23, 1, null, null },
                    { 2311, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЧИМБОЙ ТУМАНИ", 23, 1, null, null },
                    { 2312, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ШУМАНАЙ ТУМАНИ", 23, 1, null, null },
                    { 2313, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТАХТАКЎПИР ТУМАНИ", 23, 1, null, null },
                    { 2314, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ХОЖЕЛИ ТУМАНИ", 23, 1, null, null },
                    { 2315, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БОЗАТАУ ТУМАНИ", 23, 1, null, null },
                    { 2316, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚОРАУЗОҚ ТУМАНИ", 23, 1, null, null },
                    { 2317, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НУКУС ШАҲРИ", 23, 1, null, null },
                    { 2318, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БЕРУНИЙ ШАҲРИ", 23, 1, null, null },
                    { 2319, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "КУНГИРОТ ШАҲРИ", 23, 1, null, null },
                    { 2320, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТАКИЯТОШ ШАҲРИ", 23, 1, null, null },
                    { 2321, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТЎРТКЎЛ ШАҲРИ", 23, 1, null, null },
                    { 2322, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ХОЖЕЛИ ШАҲРИ", 23, 1, null, null },
                    { 2323, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЧИМБОЙ ШАҲРИ", 23, 1, null, null },
                    { 2434, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ҚЎШТЕПА ТУМАНИ", 15, 1, null, null },
                    { 739001080, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ЯШНОБОД ТУМАНИ", 10, 1, null, null },
                    { 739001100, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ШАРОФ РАШИДОВ ТУМАНИ", 13, 1, null, null },
                    { 739001120, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "НУРАФШОН ШАҲРИ", 11, 1, null, null },
                    { 739001121, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ОҲАНГАРОН ШАҲРИ", 11, 1, null, null },
                    { 739001140, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "БЎСТОН ТУМАНИ", 17, 1, null, null },
                    { 739001141, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), null, null, null, "ТУПРОҚҚАЛЪА ТУМАНИ", 22, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "tb_cars",
                columns: new[] { "id", "brand_id", "charging_per_minute", "create_date", "create_user", "driver_id", "ev_battery_capacity", "model_id", "plate_number", "status", "update_date", "update_user", "vin_code" },
                values: new object[,]
                {
                    { 1, 3, 0.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 100, 1, "ABC123", 0, null, null, "VINCODE123" },
                    { 2, 1, 0.59999999999999998, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 120, 2, "DEF456", 0, null, null, "VINCODE456" },
                    { 3, 4, 0.69999999999999996, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 110, 3, "GHI789", 0, null, null, "VINCODE789" },
                    { 4, 2, 0.80000000000000004, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 130, 4, "JKL012", 0, null, null, "VINCODE012" },
                    { 5, 5, 0.90000000000000002, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 140, 5, "MNO345", 0, null, null, "VINCODE345" },
                    { 6, 6, 1.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 150, 6, "PQR678", 0, null, null, "VINCODE678" },
                    { 7, 7, 1.1000000000000001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 160, 7, "STU901", 0, null, null, "VINCODE901" },
                    { 8, 8, 1.2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 170, 8, "VWX234", 0, null, null, "VINCODE234" },
                    { 9, 9, 1.3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 180, 9, "YZA567", 0, null, null, "VINCODE567" },
                    { 10, 1, 1.3999999999999999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 190, 10, "BCD890", 0, null, null, "VINCODE890" },
                    { 11, 3, 1.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 200, 11, "EFG123", 0, null, null, "VINCODE123" },
                    { 12, 1, 1.6000000000000001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 210, 12, "HIJ456", 0, null, null, "VINCODE456" },
                    { 13, 4, 1.7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 220, 13, "KLM789", 0, null, null, "VINCODE789" },
                    { 14, 2, 1.8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 230, 14, "NOP012", 0, null, null, "VINCODE012" },
                    { 15, 5, 1.8999999999999999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 240, 15, "QRS345", 0, null, null, "VINCODE345" },
                    { 16, 6, 2.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 250, 16, "TUV678", 0, null, null, "VINCODE678" },
                    { 17, 7, 2.1000000000000001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 260, 17, "WXYZ01", 0, null, null, "VINCODE901" },
                    { 18, 8, 2.2000000000000002, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 270, 18, "YZA234", 0, null, null, "VINCODE234" },
                    { 19, 9, 2.2999999999999998, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 280, 19, "BCD567", 0, null, null, "VINCODE567" },
                    { 20, 1, 2.3999999999999999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), 290, 20, "EFG890", 0, null, null, "VINCODE890" }
                });

            migrationBuilder.InsertData(
                table: "tb_queue_drivers",
                columns: new[] { "id", "begin_time", "cancel_reason", "car_id", "comment", "connector_id", "create_user", "end_time", "phone_number", "plate_number", "status", "update_date", "update_user", "user_info" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7595), "CancelReason1", 1, "Comment1", 1, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 7, 16, 55, 52, 249, DateTimeKind.Local).AddTicks(7607), "1234567890", "ABC123", 1, null, null, "UserInfo1" },
                    { 2, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7615), "CancelReason2", 2, "Comment2", 2, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 7, 17, 55, 52, 249, DateTimeKind.Local).AddTicks(7616), "2345678901", "DEF456", 1, null, null, "UserInfo2" },
                    { 3, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7618), "CancelReason3", 3, "Comment3", 3, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 7, 18, 55, 52, 249, DateTimeKind.Local).AddTicks(7619), "3456789012", "GHI789", 1, null, null, "UserInfo3" },
                    { 4, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7621), "CancelReason4", 4, "Comment4", 4, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 7, 19, 55, 52, 249, DateTimeKind.Local).AddTicks(7621), "4567890123", "JKL012", 1, null, null, "UserInfo4" },
                    { 5, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7623), "CancelReason5", 5, "Comment5", 5, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 7, 20, 55, 52, 249, DateTimeKind.Local).AddTicks(7624), "5678901234", "MNO345", 1, null, null, "UserInfo5" },
                    { 6, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7628), "CancelReason6", 6, "Comment6", 6, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 7, 21, 55, 52, 249, DateTimeKind.Local).AddTicks(7628), "6789012345", "PQR678", 1, null, null, "UserInfo6" },
                    { 7, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7632), "CancelReason7", 7, "Comment7", 7, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 7, 22, 55, 52, 249, DateTimeKind.Local).AddTicks(7632), "7890123456", "STU901", 1, null, null, "UserInfo7" },
                    { 8, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7634), "CancelReason8", 8, "Comment8", 8, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 7, 23, 55, 52, 249, DateTimeKind.Local).AddTicks(7635), "8901234567", "VWX234", 1, null, null, "UserInfo8" },
                    { 9, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7637), "CancelReason9", 9, "Comment9", 9, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 8, 0, 55, 52, 249, DateTimeKind.Local).AddTicks(7637), "9012345678", "YZA567", 1, null, null, "UserInfo9" },
                    { 10, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7640), "CancelReason10", 10, "Comment10", 10, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 8, 1, 55, 52, 249, DateTimeKind.Local).AddTicks(7641), "0123456789", "BCD890", 1, null, null, "UserInfo10" },
                    { 11, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7643), "CancelReason11", 11, "Comment11", 11, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 8, 2, 55, 52, 249, DateTimeKind.Local).AddTicks(7644), "1234567890", "EFG123", 1, null, null, "UserInfo11" },
                    { 12, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7646), "CancelReason12", 12, "Comment12", 12, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 8, 3, 55, 52, 249, DateTimeKind.Local).AddTicks(7646), "2345678901", "HIJ456", 1, null, null, "UserInfo12" },
                    { 13, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7649), "CancelReason13", 13, "Comment13", 13, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 8, 4, 55, 52, 249, DateTimeKind.Local).AddTicks(7649), "3456789012", "KLM789", 1, null, null, "UserInfo13" },
                    { 14, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7651), "CancelReason14", 14, "Comment14", 14, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 8, 5, 55, 52, 249, DateTimeKind.Local).AddTicks(7652), "4567890123", "NOP012", 1, null, null, "UserInfo14" },
                    { 15, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7654), "CancelReason15", 15, "Comment15", 15, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 8, 6, 55, 52, 249, DateTimeKind.Local).AddTicks(7655), "5678901234", "QRS345", 1, null, null, "UserInfo15" },
                    { 16, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7656), "CancelReason16", 16, "Comment16", 16, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 8, 7, 55, 52, 249, DateTimeKind.Local).AddTicks(7657), "6789012345", "TUV678", 1, null, null, "UserInfo16" },
                    { 17, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7660), "CancelReason17", 17, "Comment17", 17, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 8, 8, 55, 52, 249, DateTimeKind.Local).AddTicks(7660), "7890123456", "WXYZ01", 1, null, null, "UserInfo17" },
                    { 18, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7663), "CancelReason18", 18, "Comment18", 18, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 8, 9, 55, 52, 249, DateTimeKind.Local).AddTicks(7664), "8901234567", "YZA234", 1, null, null, "UserInfo18" },
                    { 19, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7666), "CancelReason19", 19, "Comment19", 19, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 8, 10, 55, 52, 249, DateTimeKind.Local).AddTicks(7667), "9012345678", "BCD567", 1, null, null, "UserInfo19" },
                    { 20, new DateTime(2024, 2, 7, 15, 55, 52, 249, DateTimeKind.Local).AddTicks(7670), "CancelReason20", 20, "Comment20", 20, new Guid("1c095b27-d060-4ed1-9167-4c9745196e2e"), new DateTime(2024, 2, 8, 11, 55, 52, 249, DateTimeKind.Local).AddTicks(7670), "0123456789", "EFG890", 2, null, null, "UserInfo20" }
                });

            migrationBuilder.CreateIndex(
                name: "ix_sp_car_brands_create_date",
                table: "sp_car_brands",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_car_models_brand_id",
                table: "sp_car_models",
                column: "brand_id");

            migrationBuilder.CreateIndex(
                name: "ix_sp_car_models_create_date",
                table: "sp_car_models",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_districts_create_date",
                table: "sp_districts",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_districts_region_id",
                table: "sp_districts",
                column: "region_id");

            migrationBuilder.CreateIndex(
                name: "ix_sp_regions_create_date",
                table: "sp_regions",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_statuses_create_date",
                table: "sp_statuses",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_units_create_date",
                table: "sp_units",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sx_role_claims_role_id",
                table: "sx_role_claims",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "sx_roles",
                column: "normalized_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_sx_user_claims_user_id",
                table: "sx_user_claims",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_sx_user_logins_user_id",
                table: "sx_user_logins",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_sx_user_roles_role_id",
                table: "sx_user_roles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "sx_users",
                column: "normalized_email");

            migrationBuilder.CreateIndex(
                name: "ix_sx_users_sp_role_id",
                table: "sx_users",
                column: "sp_role_id");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "sx_users",
                column: "normalized_user_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_tb_alerts_create_date",
                table: "tb_alerts",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_tb_cars_brand_id",
                table: "tb_cars",
                column: "brand_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_cars_create_date",
                table: "tb_cars",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_tb_cars_model_id",
                table: "tb_cars",
                column: "model_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_image_create_date",
                table: "tb_image",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_tb_queue_drivers_begin_time",
                table: "tb_queue_drivers",
                column: "begin_time");

            migrationBuilder.CreateIndex(
                name: "ix_tb_queue_drivers_car_id",
                table: "tb_queue_drivers",
                column: "car_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_queue_drivers_create_date",
                table: "tb_queue_drivers",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_tb_queue_drivers_create_user",
                table: "tb_queue_drivers",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_tb_queue_drivers_phone_number",
                table: "tb_queue_drivers",
                column: "phone_number");

            migrationBuilder.CreateIndex(
                name: "ix_tb_queue_drivers_status",
                table: "tb_queue_drivers",
                column: "status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sp_districts");

            migrationBuilder.DropTable(
                name: "sp_statuses");

            migrationBuilder.DropTable(
                name: "sp_units");

            migrationBuilder.DropTable(
                name: "sx_role_claims");

            migrationBuilder.DropTable(
                name: "sx_user_claims");

            migrationBuilder.DropTable(
                name: "sx_user_logins");

            migrationBuilder.DropTable(
                name: "sx_user_roles");

            migrationBuilder.DropTable(
                name: "sx_user_tokens");

            migrationBuilder.DropTable(
                name: "tb_alerts");

            migrationBuilder.DropTable(
                name: "tb_image");

            migrationBuilder.DropTable(
                name: "tb_queue_drivers");

            migrationBuilder.DropTable(
                name: "sp_regions");

            migrationBuilder.DropTable(
                name: "sx_users");

            migrationBuilder.DropTable(
                name: "tb_cars");

            migrationBuilder.DropTable(
                name: "sx_roles");

            migrationBuilder.DropTable(
                name: "sp_car_models");

            migrationBuilder.DropTable(
                name: "sp_car_brands");
        }
    }
}
