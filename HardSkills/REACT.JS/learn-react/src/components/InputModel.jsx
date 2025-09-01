function InputModel({ height, width, typeI, placeIn }) {
  return (
    <input
      type={typeI}
      placeholder={placeIn}
      style={{ height, width }}
    />
  );
}
export default InputModel;
