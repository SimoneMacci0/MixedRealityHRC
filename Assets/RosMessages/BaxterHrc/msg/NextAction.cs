//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using RosMessageGeneration;

namespace RosMessageTypes.BaxterHrc
{
    public class NextAction : Message
    {
        public const string RosMessageName = "baxter_hrc/NextAction";

        public string operation;
        public int id;

        public NextAction()
        {
            this.operation = "";
            this.id = 0;
        }

        public NextAction(string operation, int id)
        {
            this.operation = operation;
            this.id = id;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(SerializeString(this.operation));
            listOfSerializations.Add(BitConverter.GetBytes(this.id));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            var operationStringBytesLength = DeserializeLength(data, offset);
            offset += 4;
            this.operation = DeserializeString(data, offset, operationStringBytesLength);
            offset += operationStringBytesLength;
            this.id = BitConverter.ToInt32(data, offset);
            offset += 4;

            return offset;
        }

        public override string ToString()
        {
            return "NextAction: " +
            "\noperation: " + operation.ToString() +
            "\nid: " + id.ToString();
        }
    }
}
