namespace CarSpecs.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string? make { get; set; }
        public string? model { get; set; }
        public string? generation { get; set; }
        public int? year_from { get; set; }
        public int? year_to { get; set; }
        public string? series { get; set; }
        public string? trim { get; set; }
        public string? body_type { get; set; }
        public int? number_of_seats { get; set; }
        public double? length_in { get; set; }
        public double? width_in { get; set; }
        public double? height_in { get; set; }
        public double? curb_weight_lbs { get; set; }
        public double? full_weight_lbs { get; set; }
        public double? maximum_torque_ft_lbs { get; set; }
        public string? injection_type { get; set; }
        public string? cylinder_layout { get; set; }
        public int? number_of_cylinders { get; set; }
        public string? engine_type { get; set; }
        public double? max_power_hp { get; set; }
        public int? number_of_gears { get; set; }
        public string? transmission { get; set; }
        public double? acceleration_0_60_m { get; set; }
        public double? max_speed_mph { get; set; }
        public double? city_fuel_mpg { get; set; }
        public int? fuel_grade { get; set; }
        public double? highway_fuel_mpg { get; set; }
    }
}
