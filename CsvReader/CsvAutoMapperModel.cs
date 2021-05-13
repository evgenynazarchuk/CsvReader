using System;

namespace CsvReader
{
    public abstract class CsvAutoMapperModel : CsvModel
    {
        public override void InitializeFromRow(ReadOnlySpan<string> columns)
        {
            var properties = this.GetType().GetProperties();

            if (columns.Length != properties.Length)
            {
                throw new CsvAutoMapperModelException("Row length is not equal properties length");
            }

            for (var i = 0; i < properties.Length; i++)
            {
                var propertyTypeString = properties[i].PropertyType.ToString();

                switch (propertyTypeString)
                {
                    case TypeString.String:
                        properties[i].SetValue(this, columns[i], null);
                        break;

                    case TypeString.Integer:
                        properties[i].SetValue(this, IntegerIsRequired(columns[i]), null);
                        break;

                    case TypeString.IntegerOrNull:
                        properties[i].SetValue(this, IntegerIsNotRequired(columns[i]), null);
                        break;

                    case TypeString.Boolean:
                        properties[i].SetValue(this, BooleanIsRequired(columns[i]), null);
                        break;

                    case TypeString.BooleanOrNull:
                        properties[i].SetValue(this, BooleanIsNotRequired(columns[i]), null);
                        break;

                    case TypeString.UnsignedInteger:
                        properties[i].SetValue(this, UnsignedIntegerIsRequired(columns[i]), null);
                        break;

                    case TypeString.UnsignedIntegerOrNull:
                        properties[i].SetValue(this, UnsignedIntegerIsNotRequired(columns[i]), null);
                        break;

                    case TypeString.LongInterger:
                        properties[i].SetValue(this, LongIntegerIsRequired(columns[i]), null);
                        break;

                    case TypeString.LongIntergerOrNull:
                        properties[i].SetValue(this, LongIntegerIsNotRequired(columns[i]), null);
                        break;

                    case TypeString.UnsignedLongInterger:
                        properties[i].SetValue(this, UnsignedLongIntegerIsRequired(columns[i]), null);
                        break;

                    case TypeString.UnsignedLongIntergerOrNull:
                        properties[i].SetValue(this, UnsignedLongIntegerIsNotRequired(columns[i]), null);
                        break;

                    case TypeString.Float:
                        properties[i].SetValue(this, FloatIsRequired(columns[i]), null);
                        break;

                    case TypeString.FloatOrNull:
                        properties[i].SetValue(this, FloatIsNotRequired(columns[i]), null);
                        break;

                    case TypeString.Double:
                        properties[i].SetValue(this, DoubleIsRequired(columns[i]), null);
                        break;

                    case TypeString.DoubleOrNull:
                        properties[i].SetValue(this, DoubleIsNotRequired(columns[i]), null);
                        break;

                    case TypeString.Decimal:
                        properties[i].SetValue(this, DecimalIsRequired(columns[i]), null);
                        break;

                    case TypeString.DecimalOrNull:
                        properties[i].SetValue(this, DecimalIsNotRequired(columns[i]), null);
                        break;

                    case TypeString.DateTime:
                        properties[i].SetValue(this, DateTimeIsRequired(columns[i]), null);
                        break;

                    case TypeString.DateTimeOrNull:
                        properties[i].SetValue(this, DateTimeIsNotRequired(columns[i]), null);
                        break;

                    case TypeString.TimeSpan:
                        properties[i].SetValue(this, TimeSpanIsRequired(columns[i]), null);
                        break;

                    case TypeString.TimeSpanOrNull:
                        properties[i].SetValue(this, TimeSpanIsNotRequired(columns[i]), null);
                        break;

                    default:
                        throw new CsvAutoMapperModelException("Unknow Type");
                }
            }
        }
    }
}
