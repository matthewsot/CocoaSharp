using ObjectiveC;

    public struct NSFastEnumerationState
    {
        CUnsignedLong state { get; set; }
        UnsafePointer<AnyObject> itemsPtr { get; set; }
        private UnsafePointer<CUnsignedLong> mutationsPtr { get; set; }
        Tuple<CUnsignedLong, CUnsignedLong, CUnsignedLong, CUnsignedLong, CUnsignedLong> extra { get; set; }
    } 