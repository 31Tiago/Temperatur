using System;

public class Wetterdaten
{
    public DateTime Datum { get; set; }
    public double Temperatur { get; set; }
    public double Luftfeuchtigkeit { get; set; }

    public Wetterdaten() { }

    public Wetterdaten(DateTime datum, double temperatur, double luftfeuchtigkeit)
    {
        if (temperatur < -50 || temperatur > 50)
            throw new ArgumentOutOfRangeException("Temperatur muss zwischen -50°C und +50°C liegen.");
        Datum = datum;
        Temperatur = temperatur;
        Luftfeuchtigkeit = luftfeuchtigkeit;
    }

    public override string ToString()
    {
        return $"{Datum.ToShortDateString()} - Temperatur: {Temperatur}°C, Luftfeuchtigkeit: {Luftfeuchtigkeit}%";
    }
}
