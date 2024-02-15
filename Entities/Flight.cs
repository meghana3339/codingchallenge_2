using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

public class Flight
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(10)]
    [Column("FlightNumber", TypeName = "varchar")]
    public string FlightNumber { get; set; }

    [Required]
    [StringLength(50)]
    [Column("Airline", TypeName = "varchar")]
    public string Airline { get; set; }

    [Required]
    [StringLength(50)]
    [Column("DepartureAirport", TypeName = "varchar")]
    public string DepartureAirport { get; set; }

    [Required]
    [StringLength(50)]
    [Column("ArrivalAirport", TypeName = "varchar")]
    public string ArrivalAirport { get; set; }

    [Required]
    [Column("DepartureDateTime")]
    public DateTime DepartureDateTime { get; set; }

    [Required]
    [Column("ArrivalDateTime")]
    public DateTime ArrivalDateTime { get; set; }

    

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal TicketPrice { get; set; }
}
