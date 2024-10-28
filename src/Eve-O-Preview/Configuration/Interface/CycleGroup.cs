using System.Collections.Generic;

namespace EveOPreview.Configuration.Implementation
{
    /// <summary>
    /// Represents a group of clients that can be cycled through using hotkeys.
    /// </summary>
    public class CycleGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CycleGroup"/> class.
        /// </summary>
        public CycleGroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CycleGroup"/> class.
        /// </summary>
        /// <param name="forwardHotkeys">A list of hotkeys to cycle forward through the clients.</param>
        /// <param name="backwardHotkeys">A list of hotkeys to cycle backward through the clients.</param>
        /// <param name="clientsOrder">A dictionary representing the order of clients in the cycle group, where the key is the client name and the value is the order index.</param>
        public CycleGroup(List<string> forwardHotkeys, List<string> backwardHotkeys, Dictionary<string, int> clientsOrder)
        {
            this.ForwardHotkeys = forwardHotkeys;
            this.BackwardHotkeys = backwardHotkeys;
            this.ClientsOrder = clientsOrder;
        }

        /// <summary>
        /// Gets or sets the forward hotkeys for the cycle group.
        /// </summary>
        public List<string> ForwardHotkeys { get; set; }

        /// <summary>
        /// Gets or sets the backward hotkeys for the cycle group.
        /// </summary>
        public List<string> BackwardHotkeys { get; set; }

        /// <summary>
        /// Gets or sets the order of clients in the cycle group.
        /// </summary>
        public Dictionary<string, int> ClientsOrder { get; set; }
    }
}